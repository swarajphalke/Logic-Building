using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Number_Programs
{
    internal class PerfectNumber
    {
        void IsPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(sum + " is Perfect Number");
            }
            else
            {
                Console.WriteLine(sum + " is not Perfect Number");
            }
        }

        public static void Main(string[] args)
        {
            PerfectNumber p = new PerfectNumber();
            p.IsPerfect(6);
        }
    }
}
