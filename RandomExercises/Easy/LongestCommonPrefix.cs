namespace RandomExercises.Easy
{
    //https://leetcode.com/problems/longest-common-prefix
    public static class LongestCommonPrefix
    {
        public static string Logic1(string[] strs)
        {
            var shortestString = strs.Min(s => s.Length);
            var result = "";
            for (int i = 0; i < shortestString; i++)
            {
                var currentChar = strs[0][i];
                foreach (var str in strs)
                {
                    if (str[i] != currentChar)
                        return result;
                }
                result += currentChar;
            }
            return result;
        }

        public static string Logic2(string[] strs)
        {
            if (strs.Length == 0) return "";

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix)) return "";
                }
            }

            return prefix;
        }
    }
}