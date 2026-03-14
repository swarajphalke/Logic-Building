using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_String_Programs
{
    internal class PalindromeString
    {
        void IsPalindrome(string str)
        {
            string reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            if (str == reverse)
                Console.WriteLine(reverse + " String is Palindrome");
            else
                Console.WriteLine(reverse + " String is not Palindrome");
        }

        public static void Main(string[] args) {
            PalindromeString s = new PalindromeString();
            s.IsPalindrome("aaabbbaaa");
        }
    }
}
