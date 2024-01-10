namespace LeetCode
{
    internal class LeetCode88
    {
        private static readonly int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        private static readonly int[] nums2 = { 2, 5, 6 };
        private static readonly int m = 3;
        private static readonly int n = 3;

        public static void Run()
        {
            Merge(nums1, m, nums2, n);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }

            Array.ForEach(nums1, Console.Write);
            Console.Write("\n");
        }
    }
}
