namespace RandomExercises.Hard
{
    //https://leetcode.com/problems/substring-with-concatenation-of-all-words
    public static class SubstringConcatenationAllWords
    {
        public static IList<int> Logic1(string s, string[] words)
        {
            var result = new List<int>();
            var wordLng = words[0].Length;
            var subStringLength = wordLng * words.Length;

            if (s.Length < subStringLength)
                return result;

            var subStringDict = new Dictionary<string, int>();
            var wordsDict = new Dictionary<string, int>();
            foreach (var word in words)
                wordsDict[word] = wordsDict.GetValueOrDefault(word, 0) + 1;

            var start = 0;

            for (int end = wordLng * words.Length; end <= s.Length; end++)
            {
                var stringInWindow = s[start..end];
                for (int i = 0; i < words.Length; i++)
                {
                    var word = stringInWindow.Substring(wordLng * i, 3);
                    subStringDict[word] = subStringDict.GetValueOrDefault(word, 0) + 1;
                }

                var matches = 0;
                foreach (var keyValue in wordsDict)
                {
                    if (subStringDict.TryGetValue(keyValue.Key, out int value) && keyValue.Value == value)
                        matches += keyValue.Value;
                    else
                        break;
                }

                if (matches == words.Length)
                    result.Add(start);

                start++;
            }

            return result;
        }
    }
}