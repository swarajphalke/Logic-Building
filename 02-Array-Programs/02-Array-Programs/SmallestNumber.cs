using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class SmallestNumber
    {
        void Smallest(int[] arr)
        {
            int min = arr[0];

            for(int i = 1; i<arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Smallest Number is "+min);
        }

        public static void Main(string[] args)
        {
            SmallestNumber s = new SmallestNumber();
            s.Smallest(new int[] { 1, 2, 3, 44, 5 });
        }
    }
}
