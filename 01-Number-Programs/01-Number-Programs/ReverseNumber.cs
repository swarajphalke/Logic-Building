using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Number_Programs
{
    internal class ReverseNumber
    {
        void Reverse(int num)
        {
            int reverse = 0;
            while (num > 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num = num / 10;
            }

            Console.WriteLine(reverse);
        }

        public static void Main(string[] args)
        {
            ReverseNumber r = new ReverseNumber();
            r.Reverse(12345);
        }
    }
}
