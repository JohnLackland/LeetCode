namespace RoadmapExercises.ArraysAndHashes
{
    // https://leetcode.com/problems/contains-duplicate/
    public static class ContainsDuplicate
    {
        public static bool Logic1(int[] nums)
        {
            var hash = new HashSet<int>();
            foreach (int i in nums)
            {
                if(hash.Contains(i))
                    return true;

                hash.Add(i);
            }

            return false;
        }
    }
}