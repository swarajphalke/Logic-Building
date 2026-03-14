using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class CountEvenOdd
    {
        public static (int even, int odd) Count(int[] arr)
        {
            int even = 0;
            int odd = 0;

            for (int i =0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }
            return (even,odd);
        }

        public static void Main()
        {
            var result = Count(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Even: "+result.even);
            Console.WriteLine("Odd: "+result.odd);

        }

    }
}
