using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class LinearSearch
    {
        public static int FindIndex(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 3 };
            int key = 3;

            int index = FindIndex(arr, key);
            if (index != -1)
            {
                Console.WriteLine("Element found at index: " + index);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
