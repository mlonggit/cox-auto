using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoxAutoCode
{
    public class PalindromeDetection
    {

        public static void checkPalindrone()
        {
            string[] array =
	        {
	            "civic",
	            "deified",
	            "deleveled",
	            "devoved",
	            "dewed",
	            
	            "Pop",
	            "Net",
	            "Ah",
	            "sees",
	            "Natasha",
	            "Satan",
	            "Palindrome"
	            
	        };

            foreach (string value in array)
            {
                if(IsPalindrome(value))
                {
                    Console.WriteLine("\n\t{0} -- {1}", value, "is a palindrome");
                }
                else
                {
                    Console.WriteLine("\n\t{0}--{1}", value, "is not a palindrome");
                }
            }

            Console.WriteLine(Environment.NewLine);
        }


        /// <summary>
        /// Determines whether the string is a palindrome.
        /// </summary>
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }


    }
}
