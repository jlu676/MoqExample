using System;
using System.Security;
using System.Runtime.InteropServices;

namespace MoqExample.Models
{
    public interface IUser
    {
        string UserName { get; set; }
        string Password {get;set;}
    }


    public class User 
    {
        public User(IUser user)
        {
            _username =  user.UserName;
            _securePassword = user.Password.ToSecureString();;

        }

        private string _username;
        private SecureString _securePassword;

        public string UserName { get; set; }
        public string Password
        {
            get
            {
                return _securePassword.ToInsecureString();
            }
        }

          public AuthCode Login()
        {
            var UserId = Authenticate();

            if (string.IsNullOrEmpty(_username))
            {
                Console.WriteLine("Missing Username");
                return null;
            }
            else if (string.IsNullOrEmpty(Password))
            {
                Console.WriteLine("Missing Password");
                return null;
            }
            else if (UserId != null)
            {
                Console.WriteLine($"User {_username} Authenticated");
                return new AuthCode((int)UserId);
            }
            else
            {
                Console.WriteLine("General Error");
                return null;
            }
        }

        private int? Authenticate()
        {
            //TODO: Create Authentication procedure which returns user id 
            // if correct loging or null value if bad
            return 16327;
        }
    }
}