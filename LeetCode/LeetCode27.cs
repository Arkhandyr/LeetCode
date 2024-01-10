using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LeetCode27
    {
        private static readonly int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
        private static readonly int val = 2;

        public static void Run()
        {
            RemoveElement(nums, val);
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            foreach (var num in nums)
            {
                if (num != val)
                {
                    nums[count] = num;
                    count++;
                }
            }

            Array.ForEach(nums, Console.Write);
            Console.WriteLine("\n"+count);
            return count;
        }
    }
}
