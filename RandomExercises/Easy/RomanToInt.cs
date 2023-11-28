namespace RandomExercises.Easy
{
    //https://leetcode.com/problems/roman-to-integer
    public static class RomanToInt
    {
        public static int Logic1(string s)
        {
            var sum = 0;
            var dict = IntiDict();
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 >= s.Length || dict[s[i]] >= dict[s[i + 1]])
                    sum += dict[s[i]];
                else
                    sum -= dict[s[i]];
            }
            return sum;
        }

        private static Dictionary<char, int> IntiDict() => new Dictionary<char, int>() {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };
    }
}