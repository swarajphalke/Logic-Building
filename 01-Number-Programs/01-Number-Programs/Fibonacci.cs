using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Number_Programs
{
    internal class Fibonacci
    {
        void FibonacciSeries(int num)
        {
            int first = 0;
            int second = 1;
            Console.WriteLine(first);
            Console.WriteLine(second);

            for(int i = 2; i<=num; i++)
            {
                int next = first + second;
                Console.WriteLine(next);
                first = second;
                second = next;
            }
        }

        public static void Main(string[] args)
        {
            Fibonacci f = new Fibonacci();
            f.FibonacciSeries(5);
        }
    }
}
