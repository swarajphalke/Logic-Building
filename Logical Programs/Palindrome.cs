using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Palindrome
    {
        public static void IsPalindrome(int num)
        {
            int original = num;
            int reverse = 0;
            while (num > 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num = num / 10;
            }
            if(original == reverse)
                Console.WriteLine("Palindrome");

        }

        public static void Main()
        {
            IsPalindrome(22312);
        }
    }
}
