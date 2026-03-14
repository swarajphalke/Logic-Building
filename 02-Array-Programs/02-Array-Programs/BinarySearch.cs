using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class BinarySearch
    {
        public static int Search(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }else if (arr[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int key = 7;
            int index = Search(arr, key);

            if(index != -1)
            {
                Console.WriteLine("Element found at index: "+ index);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
