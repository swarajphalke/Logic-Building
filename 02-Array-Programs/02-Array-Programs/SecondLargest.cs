using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class SecondLargest
    {
        void Second(int[] arr)
        {
            int first = arr[0];
            int second = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }
            Console.WriteLine("Second Largest Number is " + second);
        }

        public static void Main(string[] args)
        {
            SecondLargest s = new SecondLargest();
            s.Second(new int[] { 22, 13, 32, 15 });
        }
    }
}
