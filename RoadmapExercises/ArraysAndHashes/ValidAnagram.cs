namespace RoadmapExercises.ArraysAndHashes
{
    //https://leetcode.com/problems/valid-anagram/
    public static class ValidAnagram
    {
        public static bool Logic1(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                map[s[i]] = map.GetValueOrDefault(s[i], 0) + 1;
                map[t[i]] = map.GetValueOrDefault(t[i], 0) - 1;
            }

            return !map.Any(kv => kv.Value != 0);
        }

        public static bool Logic2(string s, string t)
        {
            var sArray = s.ToCharArray();
            var tArray = t.ToCharArray();
            Array.Sort(sArray);
            Array.Sort(tArray);
            return new string(sArray) == new string(tArray);
        }

        public static bool Logic3(string s, string t)
        {
            return new string(s.OrderBy(c => c).ToArray()) == new string(t.OrderBy(c => c).ToArray());
        }
    }
}