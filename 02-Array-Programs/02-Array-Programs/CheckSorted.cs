using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class CheckSorted
    {
        public static bool Check(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            if (Check(arr))
            {
                Console.WriteLine("Array is Sorted");
            }
            else
            {
                Console.WriteLine("Array is not Sorted");
            }
        }
    }
}
