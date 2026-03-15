using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class SingleNumber
    {
        public static int Single(int[] nums)
        {
            int result = 0;
            foreach (int n in nums)
            {
                result ^= n;
            }
            return result;
        }

        public static void Main()
        {
            int[] arr = { 1, 1, 2, 2, 3 };
            int ans = Single(arr);
            System.Console.WriteLine(ans);
        }
    }

}