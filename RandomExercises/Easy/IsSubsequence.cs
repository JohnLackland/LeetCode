namespace RandomExercises.Easy
{
    //https://leetcode.com/problems/is-subsequence
    public static class IsSubsequence
    {
        public static bool Logic1(string s, string t)
        {
            var foundCharsCount = 0;
            foreach (var c in t)
            {
                if (foundCharsCount <= s.Length - 1 && s[foundCharsCount] == c)
                    foundCharsCount++;
            }
            return s.Length == foundCharsCount;
        }
    }
}