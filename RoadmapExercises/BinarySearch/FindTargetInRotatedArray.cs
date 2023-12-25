namespace RoadmapExercises.BinarySearch
{
    //https://leetcode.com/problems/search-in-rotated-sorted-array/
    public static class FindTargetInRotatedArray
    {
        public static int Logic1(int[] nums, int target)
        {
            var low = 0;
            var high = nums.Length - 1;

            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (nums[mid] == target)
                    return mid;

                if (nums[low] <= nums[mid])
                {
                    if (target > nums[mid] || target < nums[low])
                        low = mid + 1;
                    else 
                        high = mid - 1;
                }
                else
                {
                    if (nums[mid] > target || nums[high] < target)
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
            }

            return -1; // Target not found
        }
    }
}