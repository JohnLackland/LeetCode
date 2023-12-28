namespace RandomExercises.Easy
{
    //https://leetcode.com/problems/range-sum-query-immutable/
    public class RangeSumQueryImmutable
    {
        private static int[] preSums;
        public RangeSumQueryImmutable(int[] nums)
        {
            preSums = nums;

            for (int i = 1; i < nums.Length; i++)
                preSums[i] += preSums[i - 1];
        }

        public static int SumRange(int left, int right)
        {
            if (left == 0)
                return preSums[right];

            return preSums[right] - preSums[left -1];
        }

    }
}