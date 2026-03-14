using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Number_Programs
{
    internal class CountDigits
    {
        void Count(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine("Digits are " + count);

        }

        public static void Main(string[] args)
        {
            CountDigits c = new CountDigits();
            c.Count(101010);
        }
    }
}
