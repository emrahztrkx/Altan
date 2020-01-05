namespace Altan.Application.Contract.Users.Dto
{
    public class AddUserInput
    {
        public string Password { get; set; }
        
        public string Email { get; set; }
        
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }
    }
}