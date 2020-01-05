using System.Collections;
using System.Collections.Generic;
using Altan.Core.Common;
using Altan.Core.Organizations;

namespace Altan.Core.Users
{
    public class User : BaseEntity
    {

        public User(string password)
        {
            // TODO: password hashlenecek
            Password = password;
        }
        
        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get;  set; }

        public bool IsActive { get; set; }

        public string Password { get;private set; }
    }
}