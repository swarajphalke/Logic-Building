using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class LargestNumber
    {
        void Largest(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Largest Number is " + max);
        }

        public static void Main(string[] args)
        {
            LargestNumber l = new LargestNumber();
            int[] num = { 1, 2, 3, 11 };
            l.Largest(num);
            //l.Largest(new int[] { 1, 2, 34, 5, 6 });
        }
    }
}
