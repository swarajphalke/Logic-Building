using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Programs
{
    internal class RotateArray
    {
        public static void Rotate(int[] nums, int key)
        {
            int n = nums.Length;
            key = key % n;

            Reverse(nums, 0, n - 1);
            Reverse(nums, 0, key - 1);
            Reverse(nums, key, n - 1);

            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
        }
        public static void Reverse(int[] nums, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }

        public static void Main()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int key = 3;
            Rotate(nums, key);
        }
    }
}
