namespace RandomExercises.Easy
{
    //https://leetcode.com/problems/contains-duplicate-ii
    public static class ContainsDuplicateII
    {
        // hashmap
        public static bool Logic1(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]) && Math.Abs( dict[nums[i]] - i) <= k)
                    return true;

                dict[nums[i]] = i;
            }

            return false;
        }

        //SlidingWindow
        public static bool Logic2(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var j = i + 1;
                while (j < nums.Length && Math.Abs(j - i) < k)
                {
                    if (nums[i] == nums[j])
                        return true;
                    j++;
                }
            }

            return false;
        }

        //SlidingWindow + Dictinary
        public static bool Logic3(int[] nums, int k)
        {
            var hash = new HashSet<int>();
            var l = 0;
            for (int r = 0; r < nums.Length; r++)
            {
                if (r - l + 1 > k)
                {
                    hash.Remove(nums[l]);
                    l++;
                }

                if (hash.Contains(r))
                    return true;

                hash.Add(nums[r]);
            }

            return false;
        }
    }
}