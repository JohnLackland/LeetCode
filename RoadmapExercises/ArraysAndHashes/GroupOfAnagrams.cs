namespace RoadmapExercises.ArraysAndHashes
{
    //https://leetcode.com/problems/group-anagrams/
    public static class GroupOfAnagrams
    {
        public static IList<IList<string>> Logic1(string[] strs)
        {
            var map = new Dictionary<string, IList<string>>();
            foreach (var word in strs)
            {
                var wordCharArr = word.ToCharArray();
                Array.Sort(wordCharArr);
                var sortedWord = new string(wordCharArr);

                if (!map.TryGetValue(sortedWord, out _))
                    map[sortedWord] = new List<string>();

                map[sortedWord].Add(word);
            }

            return map.Values.ToList();
        }
    }
}