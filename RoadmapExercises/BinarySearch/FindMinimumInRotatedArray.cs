namespace RoadmapExercises.BinarySearch
{
    //https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
    public static class FindMinimumInRotatedArray
    {
        public static int Logic1(int[] nums)
        {
            var low = 0;
            var high = nums.Length - 1;

            while (low <= high)
            {
                if (nums[low] <= nums[high])
                    return nums[low];

                var mid = low + (high - low) / 2;

                if (nums[low] <= nums[mid])
                    low = mid + 1;
                else
                    high = mid;

            }

            return -1; // should not be reached
        }
    }
}