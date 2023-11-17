namespace RoadmapExercises.SlidingWindow
{
    //https://leetcode.com/problems/longest-repeating-character-replacement/
    public static class LongestRepeatingCharacterReplacement
    {
        // O(26n) becuase we count most frequent chars in the dict in every round
        public static int Logic1(string s, int k)
        {
            var dict = new Dictionary<char, int>();
            var result = 0;
            var start = 0;

            for (var end = 0; end < s.Length; end++)
            {
                dict[s[end]] = dict.GetValueOrDefault(s[end], 0) + 1;
                var mostFreqChar = dict.Count > 0 ? dict.Max(x => x.Value) : 0;
                while ((end - start + 1) - mostFreqChar > k)
                {
                    dict[s[start]] = dict[s[start]] - 1;
                    start++;
                }

                result = Math.Max(result, end - start + 1);
            }
            return result;
        }

        // Faster logic becuse we store the most frequent char and we do not need to look up the dict every time to find it
        public static int Logic2(string s, int k)
        {
            var dict = new Dictionary<char, int>();
            var result = 0;
            var start = 0;
            var mostFreqCharCount = 0;
            for (var end = 0; end < s.Length; end++)
            {
                dict[s[end]] = dict.GetValueOrDefault(s[end], 0) + 1;
                mostFreqCharCount = Math.Max(mostFreqCharCount, dict[s[end]]);
                while ((end - start + 1) - mostFreqCharCount > k)
                {
                    dict[s[start]]--;
                    start++;
                }

                result = Math.Max(result, end - start + 1);
            }
            return result;
        }
    }
}