using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_String_Programs
{
    internal class ReverseStringInArray
    {
        public static void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while(left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                left++;
                right--;
            }
            Console.WriteLine(s);
        }

        public static void Main()
        {
            ReverseString(new char[] { 'h','e','l','l','o' });
        }
    }
}
