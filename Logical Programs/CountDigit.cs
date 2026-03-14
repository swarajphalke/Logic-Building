using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class CountDigit
    {
        void Digit(int num)
        {
            int count = 0;

            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);
        }

        public static void Main()
        {
            CountDigit c = new CountDigit();
            c.Digit(23222);
        }
    }
}
