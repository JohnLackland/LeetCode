namespace RoadmapExercises.ArraysAndHashes
{
    //https://leetcode.com/problems/longest-consecutive-sequence/
    public static class LongestConsecutiveSequence
    {
        public static int Logic1(int[] nums)
        {
            if (nums.Length < 2)
                return nums.Length;

            var set = new HashSet<int>(nums);
            var longestSequence = 1;

            foreach (var num in set) {
                if (!set.Contains(num - 1))
                {
                    var currentLength = 1;
                    while(set.Contains(num + currentLength))
                    {
                        currentLength++;
                        longestSequence = Math.Max(longestSequence, currentLength);
                    }
                }
            }

            return longestSequence;
        }
    }
}