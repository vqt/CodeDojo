namespace CodeDojo
{
    public partial class Solution
    {
        // Find First and Last Position of Element in Sorted Array
        public int[] SearchRange(int[] nums, int target)
        {
            var left = BinarySearchL(nums, target);
            if (left == nums.Length || nums[left] != target) return new int[] { -1, -1 };
            var right = BinarySearchR(nums, target);
            return new int[] { left, right };
        }
        public int BinarySearchL(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] >= target) right = mid; else left = mid + 1;
            }
            return left;
        }
        public int BinarySearchR(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] > target) right = mid; else left = mid + 1;
            }
            return --right;
        }
    }
}
