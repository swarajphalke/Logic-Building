using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class SortArray
    {
        void sort(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            foreach (int num in arr)
            {
                Console.Write(num+" ");
            }
        }

        public static void Main(string[] args)
        {
            SortArray s = new SortArray();
            s.sort(new int[] { 1, 3, 5, 2, 4 });
        }
    }
}

