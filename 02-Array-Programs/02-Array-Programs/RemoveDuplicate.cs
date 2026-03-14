using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class RemoveDuplicate
    {
        void duplicate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool IsDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        IsDuplicate = true;
                        break;
                    }
                }
                if (!IsDuplicate)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        public static void Main(string[] args)
        {
            RemoveDuplicate r = new RemoveDuplicate();
            r.duplicate(new int[] { 1, 2, 3, 4, 3, 2, 4 });
        }
    }
}
