using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class TwoSum
    {
        public static int[] TwoSumSeries(int[] num, int target) { 
            for(int i = 0; i<num.Length; i++)
            {
                for(int j = i+1; j<num.Length; j++)
                {
                    if (num[i] + num[j] == target)
                    {
                        return new int[] { num[i], num[j] };
                    }
                }
            }
            return new int[] { };
        }

        public static void Main()
        {
           int[] result = TwoSumSeries(new int[] { 1, 2, 3, 4, 5 }, 9);
            Console.WriteLine(result[0]+" " + result[1]);
        }

    }
}
