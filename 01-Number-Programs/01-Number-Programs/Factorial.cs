using System;

namespace _01_Number_Programs
{
    internal class Factorial
    {
        void FactorialSeries(int num)
        {
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factoial of " + num + " is " + fact);
        }

        public static void Main(string[] args)
        {
            Factorial f = new Factorial();
            f.FactorialSeries(10);
        }
    }
}
