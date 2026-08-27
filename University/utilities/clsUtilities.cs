using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace University.utilities
{
    public class clsUtilities
    {
        public static bool EmailValidating(string Text)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (Regex.IsMatch(Text , pattern))
            {
                return true;
            }

            return false;
        }

        public static string ComputeHash(string Password)
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Password));


                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
