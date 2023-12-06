namespace RandomExercises.Medium
{
    public static class RemoveDuplicates2
    {
        public static int Logic1(int[] nums)
        {
            if (nums.Length <= 2)
                return nums.Length;

            var slow = 2;

            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[slow - 2] != nums[fast])
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
            }

            return slow;
        }
    }
}