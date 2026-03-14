using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Factorial
    {
       public static void FactorialSeries(int num)
        {
            int result = 1;

            for(int i = 1; i<=num; i++)
            {
                result *= i;
            Console.WriteLine(i + "! = "+result);
            }
        }

        public static void Main()
        {
            FactorialSeries(5);
        }
    }
}
