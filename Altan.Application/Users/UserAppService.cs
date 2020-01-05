using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Altan.Application.Contract.Users;
using Altan.Application.Contract.Users.Dto;
using Altan.Core;
using Altan.Core.Shared.Exceptions;
using Altan.Core.Users;
using Microsoft.EntityFrameworkCore;

namespace Altan.Application.Users
{
    public class UserAppService : AppService, IUserAppService
    {
        private readonly IRepository<User> _userRepository;
      
        public UserAppService(IRepository<User> userRepository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUser(string emailAddressOrPhoneNumber, string password)
        {
            // TODO: sifrelemesi degisince burasi da degisecek.
            var user = await _userRepository.Query().FirstOrDefaultAsync(x =>
                (x.Email == emailAddressOrPhoneNumber || x.PhoneNumber == emailAddressOrPhoneNumber) &&
                x.Password == password);

            if (user == null)
                throw new UserFriendlyException(ExceptionCode.NotFoundUser, "User not found");

            if (!user.IsActive)
                throw new UserFriendlyException(ExceptionCode.NotActiveUser, "User is not active");

            return user;
        }

        public async Task AddUser(AddUserInput input)
        {
            // check same user
            var isExists = _userRepository.Query()
                .Any(x => x.Email == input.Email || x.PhoneNumber == input.PhoneNumber);

            if (isExists)
                throw new UserFriendlyException(ExceptionCode.AlreadyRegistered,
                    "Already registered with phone number or email address");

            var user = new User(input.Password)
            {
                Email = input.Email,
                FullName = input.FullName,
                IsActive = true,
                PhoneNumber = input.PhoneNumber
            };

            await _userRepository.AddAsync(user);
            
            await _unitOfWork.SaveAsync();
        }
    }
}