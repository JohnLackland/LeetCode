namespace RandomExercises.Medium
{
    //https://leetcode.com/problems/subarray-sum-equals-k/
    public static class SubarraySumEqualsK
    {
        public static int Logic1(int[] nums, int k)
        {
            var result = 0;
            var dict = new Dictionary<int, int>
            {
                [0] = 1
            };
            var sum = 0;
            foreach (var num in nums) 
            {
                sum += num;
                var diff = sum - k;

                dict.TryGetValue(diff, out int value);
                result += value;

                dict[diff] = dict.GetValueOrDefault(diff, 0) + 1;
            }

            return result;
        }
    }
}