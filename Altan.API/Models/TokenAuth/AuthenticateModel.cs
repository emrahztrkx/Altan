namespace Altan.API.Models.TokenAuth
{
    public class AuthenticateModel
    {
        public string EmailAddressOrPhoneNumber { get; set; }
        
        public string Password { get; set; }
    }
}