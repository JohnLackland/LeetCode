namespace RandomExercises.Medium
{
    public static class MinSubArrayLen
    {
        //https://leetcode.com/problems/minimum-size-subarray-sum
        public static int Logic1(int target, int[] nums)
        {
            var result = int.MaxValue;
            var s = 0;
            var sum = 0;
            for (int r = 0; r < nums.Length; r++)
            {
                sum += nums[r];
                while (sum >= target)
                {
                    result = Math.Min(result, r - s + 1);
                    sum -= nums[s];
                    s++;
                }
            }

            return result == int.MaxValue ? 0 : result;
        }
    }
}