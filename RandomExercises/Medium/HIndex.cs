namespace RandomExercises.Medium
{
    // https://leetcode.com/problems/h-index
    public static class HIndex
    {
        public static int Logic1(int[] citations)
        {
            Array.Sort(citations, (a, b) => b.CompareTo(a));
            var result = 0;
            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[i] > i)
                    result++;
                else
                    return result;
            }

            return result;
        }
    }
}