using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Altan.API.Models;
using Altan.API.Models.TokenAuth;
using Altan.API.Models.Users;
using Altan.Application;
using Altan.Application.Contract.Users;
using Altan.Application.Contract.Users.Dto;
using Altan.Core.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Altan.API.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserAppService _userAppService;
        private readonly AppSettings _appSettings;

        public UsersController(IUserAppService userAppService, IOptions<AppSettings> appSettings)
        {
            _userAppService = userAppService;
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ResponseBase<AuthenticateResult>> Authenticate([FromBody] AuthenticateModel model)
        {
            var user = await _userAppService.GetUser(model.EmailAddressOrPhoneNumber, model.Password);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddSeconds(36000),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));

            return Response<AuthenticateResult>(new AuthenticateResult()
            {
                Token = token,
                ExpiresInSeconds = 36000
            });
        }


        [HttpPut]
        public async Task<ResponseBase> Register([FromBody] RegisterModel model)
        {
            await _userAppService.AddUser(new AddUserInput()
            {
                Email = model.Email,
                Password = model.Password,
                FullName = model.FullName,
                PhoneNumber = model.PhoneNumber
            });

            return Response();
        }
    }
}