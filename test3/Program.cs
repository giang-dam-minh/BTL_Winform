using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "1/1/2021 12:00:00 PM";

            Console.WriteLine(str.Substring(0,8));
            Console.ReadLine();
        }
        static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool EmailIsValid(string email)
        {
            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expression))
            {
                if (Regex.Replace(email, expression, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }
       
    }
}
