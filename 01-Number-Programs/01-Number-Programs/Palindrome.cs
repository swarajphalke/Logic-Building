using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Number_Programs
{
    internal class Palindrome
    {
        void IsPalindrome(int num)
        {
            int original = num;
            int reverse = 0;

            while (num > 0)
            {
                int digits = num % 10;
                reverse = reverse * 10 + digits;
                num = num / 10;
            }

            if (original == reverse)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }

        public static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            p.IsPalindrome(125521);
        }
    }
}
