using System.Threading.Tasks;
using Altan.Application.Contract.Users.Dto;
using Altan.Core.Users;

namespace Altan.Application.Contract.Users
{
    public interface IUserAppService 
    {
        // authenticate
        Task<User> GetUser(string emailAddressOrPhoneNumber, string password);

        Task AddUser(AddUserInput input);
    }
}