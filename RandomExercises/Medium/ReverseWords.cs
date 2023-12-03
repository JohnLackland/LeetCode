using System.Text;

namespace RandomExercises.Medium
{
    //https://leetcode.com/problems/reverse-words-in-a-string
    public static class ReverseWords
    {
        public static string Logic1(string s)
        {
            var splittedWords = s.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            var strBuilder = new StringBuilder();

            for (int i = splittedWords.Length - 1; i >= 0; i--)
            {
                strBuilder.Append(splittedWords[i]);
                if (i != 0)
                    strBuilder.Append(' ');
            }
            return strBuilder.ToString();
        }
    }
}