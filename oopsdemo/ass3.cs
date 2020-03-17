using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{


    class ass3
    {
        static String firstLetterWord(String str)
        {
            String result = "";
            // Traverse the string.  
            bool v = true;
            for (int i = 0; i < str.Length; i++)
            {
                // If it is space, set v as true.  
                if (str[i] == ' ')
                {
                    v = true;
                }

                // Else check if v is true or not.  
                // If true, copy character in output  
                // string and set v as false.  
               else if (str[i] != ' ' && v == true)
                {
                    result += (str[i]);
                    v = false;
                }
            }
            return result;
        }


        public static void Main()
        {
            Console.WriteLine("Enter name:");
            string Name = Console.ReadLine();
            string result;
            result = Name.Replace("a", "A");
            Console.WriteLine(result);
            Console.WriteLine(firstLetterWord(Name));
            string s = "";
            char[] namechar = Name.ToArray();
            for (int i = 0; i < namechar.Count(); i++)
            {
                if ((i % 2) == 0) // Check it is odd or even (Means character position)
                {
                    s += namechar[i].ToString().ToUpper();
                }
                else
                {
                    s += namechar[i].ToString().ToLower();
                }
            }
            Console.Write(s);
            Console.Read();
        }
    }
}
