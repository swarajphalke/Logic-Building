using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class FibonacciSeries
    {
        public static void Fibonacci(int num)
        {
            int first = 0;
            int second = 1;
            Console.WriteLine(first);
            Console.WriteLine(second);
            for(int i = 1; i <= num; i++)
            {
                int next = first + second;
                first = second;
                second = next;

                Console.WriteLine(next);
            }
        }

        public static void Main()
        {
            Fibonacci(5);
        }
    }
}
