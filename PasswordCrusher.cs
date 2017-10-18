using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCrusher
{

    class PasswordCrusher
    {
        static void Main(string[] args)
        {

            string password = "P@s$w0Rd!";
            Console.WriteLine($"Hasło: \n{password}");
            Console.ReadKey();
        }
        static string passwordCrusher(string password)
        {
            int[] passwordCrusher = new int[password.Length];
            char[] passwordCrusherChar = new char[password.Length];
            for (int i = 0; i <= password.Length - 1; i++)
            {
                for (int j = 1; j <= 127; j++)
                {
                    if (j == password[i])
                    {
                        passwordCrusher[i] = j;
                        passwordCrusherChar[i] = Convert.ToChar(passwordCrusher[i]);
                    }
                }
            }
            string brokenPassword = new string(passwordCrusherChar);
            return brokenPassword;
        }
    }
}