using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class FindFrequency
    {
        public static int Frequency(int[] arr, int key)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    count++;
                }
            }
            return count;
        }

        public static void Main()
        {
            int[] arr = { 1, 2, 3, 2, 4, 2, 5 };
            int key = 2;
            int result = Frequency(arr, key);
            Console.WriteLine("Frequency of " + key + " is: " + result);
        }
    }
}
