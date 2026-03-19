using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class ZeroToEnd
    {
        public static void Move(int[] arr)
        {
            int temp;
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        public static void Main()
        {
            int[] arr = { 0, 1, 0, 3, 12 };
            Move(arr);
        }
    }
}
