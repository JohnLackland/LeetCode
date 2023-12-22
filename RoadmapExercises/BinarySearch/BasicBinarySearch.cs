namespace RoadmapExercises.BinarySearch
{
    //https://leetcode.com/problems/binary-search/
    public static class BasicBinarySearch
    {
        public static int Logic1(int[] nums, int target)
        {
            var low = 0;
            var high = nums.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] < target)
                    low = mid + 1;
                else if(nums[mid] > target)
                    high = mid - 1;
                else
                    return mid;
            }

            return -1;
        }
    }
}