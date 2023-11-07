namespace RoadmapExercises.ArraysAndHashes
{
    //https://leetcode.com/problems/top-k-frequent-elements/
    public static class TopKFrequentElements
    {
        // O(n + n log k)
        public static int[] Logic1(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            foreach (int num in nums)
                map[num] = map.GetValueOrDefault(num, 0) + 1;

            var sortedSet = new SortedSet<(int freq, int num)>();
            foreach (var keyValue in map)
            {
                sortedSet.Add((keyValue.Value, keyValue.Key));
                if (sortedSet.Count > k)
                    sortedSet.Remove(sortedSet.Min);
            }

            return sortedSet.Select(a => a.num).ToArray();
        }

        // O(n)
        public static int[] Logic2(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            foreach (int num in nums)
                map[num] = map.GetValueOrDefault(num, 0) + 1;

            var buckets = new List<int>[nums.Length + 1];
            for (int i = 0; i <= nums.Length; i++)
                buckets[i] = new List<int>();


            foreach (var keyValue in map)
                buckets[keyValue.Value].Add(keyValue.Key);

            var result = new List<int>();
            for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
            {
                result.AddRange(buckets[i].Take(k - result.Count));
            }

            return result.ToArray();
        }
    }
}