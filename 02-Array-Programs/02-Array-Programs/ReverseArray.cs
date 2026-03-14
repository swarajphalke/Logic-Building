using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class ReverseArray
    {
        void reverse(int[] arr)
        {
            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
        }

        public static void Main(string[] args)
        {
            ReverseArray r = new ReverseArray();
            r.reverse(new int[] { 1, 2, 3, 4, 5, 6 });
        }
    }
}
