using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UtilityClass
    {
        public string EncryptData(string password)
        {
            // Adopted here: http://www.dotnetfunda.com/forums/show/16822/decrypt-password-in-aspnet

            string ms = string.Empty;
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            ms = Convert.ToBase64String(encode);
            return ms;
        }
    }
}
