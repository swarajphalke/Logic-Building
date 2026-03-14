using System;

namespace _01_Number_Programs
{
    internal class Prime
    {
        void IsPrime(int num)
        {
            if (num <= 1)
            {
                Console.WriteLine(num + " is Not Prime Number");
            }

            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    count++;
            }

            if (count == 2)
                Console.WriteLine(num + " is Prime Number");
            else
                Console.WriteLine(num + " is Not Prime Number");
        }

        public static void Main(string[] args)
        {
            Prime p = new Prime();
            p.IsPrime(7);
        }
    }
}