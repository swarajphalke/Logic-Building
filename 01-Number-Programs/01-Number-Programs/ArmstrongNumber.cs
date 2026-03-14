using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Number_Programs
{
    internal class ArmstrongNumber
    {
        void Armstrong(int num)
        {
            int original = num;
            int temp = num;
            int count = 0;
            int sum = 0;

            while (temp > 0)
            {
                count++;
                temp = temp / 10;
            }

            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + (int)Math.Pow(digit, count);
                num = num / 10;
            }

            if (original == sum)
                Console.WriteLine(sum + " is Armstrong Number");
            else
                Console.WriteLine(sum + " is not Armstrong Number");
        }

        public static void Main(string[] args)
        {
            ArmstrongNumber a = new ArmstrongNumber();
            a.Armstrong(153);
        }
    }
}
