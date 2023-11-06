using System.Text.Json.Serialization;

namespace RoadmapExercises.ArraysAndHashes
{
    //https://leetcode.com/problems/two-sum/
    public static class TwoSum
    {
        //O(n^2) time complexity
        public static int[] Logic1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++) 
                    if(i + j == target)
                        return new int[] {i, j};
            }

            // should not be encountered
            return Array.Empty<int>();
        }

        //O(n) time complexity
        public static int[] Logic2(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(map.TryGetValue(nums[i], out int index))
                    return new int[] {i, index};

                map[target - nums[i]] = i;
            }

            // should not be encountered
            return Array.Empty<int>();
        }
    }
}