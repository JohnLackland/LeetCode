namespace RoadmapExercises.SlidingWindow
{
    //https://leetcode.com/problems/permutation-in-string/
    public static class PermutationInString
    {
        public static bool Logic1(string s1, string s2)
        {
            if (s2.Length < s1.Length)
                return false;

            var s1Array = s1.ToCharArray();
            Array.Sort(s1Array);
            var sortedS1 = new string(s1Array);
            var start = 0;
            for (int end = s1.Length; end < s2.Length; end++)
            {
                var subStrArray = s2[start..end].ToCharArray();
                Array.Sort(subStrArray);
                var sortedSubString = new string(subStrArray);

                if(sortedS1 == sortedSubString)
                    return true;

                start++;
            }

            return false;
        }

        public static bool Logic2(string s1, string s2)
        {
            if (s2.Length < s1.Length)
                return false;

            var subStrDict = new Dictionary<char, int>();
            var s1Dict = new Dictionary<char, int>();
            foreach (var c in s1)
                s1Dict[c] = s1Dict.GetValueOrDefault(c, 0) + 1;
            
            var start = 0;
            for (int end = 0; end < s2.Length; end++)
            {
                subStrDict[s2[end]] = subStrDict.GetValueOrDefault(s2[end], 0) + 1;

                if (end < s1.Length - 1)
                    continue;

                bool isPermutation = true;
                foreach (var keyValue in s1Dict)
                {
                    if (!subStrDict.TryGetValue(keyValue.Key, out int value) || keyValue.Value != value)
                    {
                        isPermutation = false;
                        break;
                    }
                }

                if (isPermutation)
                    return true;

                subStrDict[s2[start]]--;
                start++;
            }

            return false;
        }
    }
}