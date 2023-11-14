namespace RoadmapExercises.SlidingWindow
{
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        // Time complexity is worse than O(n) because of the constant clear
        public static int Logic1(string s)
        {
            var result = 0;
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.TryGetValue(s[i], out int index)) {
                    result = Math.Max(result, dict.Count);
                    dict.Clear();
                    i = index + 1;
                }

                dict.Add(s[i], i);
            }
                
            return Math.Max(result, dict.Count);
        }
    }

}
