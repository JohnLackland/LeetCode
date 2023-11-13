namespace RandomExercises.Easy
{
    // https://leetcode.com/problems/remove-duplicates-from-sorted-array
    public static class RemoveDuplicatesSortedArray
    {
        public static int Logic1(int[] nums)
        {
            var hash = new HashSet<int>();
            foreach (var num in nums)
            {
                if (hash.Contains(num))
                    continue;

                hash.Add(num);
                nums[hash.Count] = num;
            }
            return hash.Count;
        }

        public static int Logic2(int[] nums)
        {
            var i = 1;
            foreach (var num in nums)
            {
                if (nums[i - 1] != num)
                    nums[i++] = num;
            }
            return i;
        }

        public static int Logic3(int[] nums)
        {
            var j = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[j] != nums[i])
                    nums[++j] = nums[i];
            }
            return j + 1;
        }
    }
}