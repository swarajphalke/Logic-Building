using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class FindDuplicate
    {
        void Duplicate(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i]);
                        break;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            FindDuplicate d = new FindDuplicate();
            d.Duplicate(new int[] { 1, 2, 4, 4, 2, 3 });
        }
    }
}
