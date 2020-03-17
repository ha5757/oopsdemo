using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace oopsdemo.mock8
{
    class Program
    {
       public static bool ValidateEmailId(string email)
        {
            String s = @"[a-zA-Z0-9._]{3,}@[A-Za-z]{3,}.[a-zA-Z]{2,6}";

            Regex regex = new Regex(s);
            if (regex.IsMatch(email))
                return true;
            else
                return false;

        }
        public static string IdentifyServiceProvider(string mobile)
        {
            if (mobile.StartsWith("9870"))
                return "Airtel";
            else if (mobile.StartsWith("7012"))
                return "Jio";
            else if (mobile.StartsWith("8180"))
                return "Vodafone";
            else
                return "the mobile number is not identified";
        }
    }
}
