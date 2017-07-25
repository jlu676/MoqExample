using System;
using System.Security;
using MoqExample;

namespace MoqExample.Models
{
    public class AuthCode
    {
        private SecureString _authKey;
        private int _authUserId;

        public AuthCode(int AuthUserId)
        {
            _authUserId = AuthUserId;
            GenerateAuthCode();
        }

        public int UserId
        {
            get
            {
                return _authUserId;
            }
        }
        public string AuthKey
        {
            get
            {
                return _authKey.ToInsecureString();
            }
        }

        private void GenerateAuthCode()
        {
            _authKey = Guid.NewGuid().ToString().Replace("-", "").ToSecureString();
        }
    }
}