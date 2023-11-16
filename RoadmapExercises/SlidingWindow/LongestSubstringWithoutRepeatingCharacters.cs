namespace RoadmapExercises.SlidingWindow
{
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        // Time complexity is worse than O(n) because of the constant clear of the dictionary
        public static int Logic1(string s)
        {
            var result = 0;
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.TryGetValue(s[i], out int index))
                {
                    result = Math.Max(result, dict.Count);
                    dict.Clear();
                    i = index + 1;
                }

                dict.Add(s[i], i);
            }

            return Math.Max(result, dict.Count);
        }

        public static int Logic2(string s)
        {
            var dict = new Dictionary<char, int>();
            var maxLength = 0;
            var start = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];
                if (dict.ContainsKey(currentChar) && start <= dict[currentChar])
                    start = Math.Max(start, dict[currentChar] + 1);

                dict[currentChar] = i;
                maxLength = Math.Max(maxLength, i - start + 1);
            }

            return maxLength;
        }

        public static int Logic3(string s)
        {
            var hash = new HashSet<char>();
            var start = 0;
            var result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                
                
                
                var currentchar = s[i];
                while (hash.Contains(currentchar))
                {
                    hash.Remove(s[start]);
                    start++;
                }

                hash.Add(currentchar);
                result = Math.Max(result, i - start + 1);
            }

            return result;
        }
    }
}