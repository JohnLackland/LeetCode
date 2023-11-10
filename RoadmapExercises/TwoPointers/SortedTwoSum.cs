namespace RoadmapExercises.TwoPointers
{
    //https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    public static class SortedTwoSum
    {
        public static int[] Logic1(int[] numbers, int target)
        {
            var firstIndex = 0;
            var lastIndex = numbers.Length - 1;
            while (firstIndex < lastIndex)
            {
                var sum = numbers[firstIndex] + numbers[lastIndex];
                if (sum == target)
                    return new[] { firstIndex + 1, lastIndex + 1 };
                else if (sum > target)
                    lastIndex--;
                else
                    firstIndex++;
            }
            return Array.Empty<int>();
        }
    }
}