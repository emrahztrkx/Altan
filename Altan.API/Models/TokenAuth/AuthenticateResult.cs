namespace Altan.API.Models.TokenAuth
{
    public class AuthenticateResult
    {
        public string Token { get; set; }

        public int ExpiresInSeconds { get; set; }
    }
}