using System;
using System.Security;
using System.Runtime.InteropServices;

namespace MoqExample
{
    public static class Extensions
    {
        public static string ToInsecureString(this SecureString secureString)
        {
                IntPtr ptr = SecureStringMarshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(ptr);      
        }

        public static SecureString ToSecureString(this string insecureString)
        {
             var secure = new SecureString();
                foreach (var ch in insecureString)
                {
                    secure.AppendChar(ch);
                }
                secure.MakeReadOnly();
                return secure;
        }

    }
}