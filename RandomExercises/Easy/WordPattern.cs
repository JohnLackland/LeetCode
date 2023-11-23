using System.Text;
using System.Text.RegularExpressions;

namespace RandomExercises.Easy
{
    //https://leetcode.com/problems/word-pattern/
    public static class WordPattern
    {
        public static bool Logic1(string pattern, string s)
        {
            var splittedS  = s.Split(" ");
            var patternDict = new Dictionary<string, int>();
            var wordDict = new Dictionary<string, int>();
            if (pattern.Length != splittedS.Length)
                return false;

            for (int i = 0; i < splittedS.Length; i++)
            {
                var containsPattern = patternDict.TryGetValue(pattern[i].ToString(), out int patternPos); 
                var containsWord = wordDict.TryGetValue(splittedS[i], out int wordPos);
                
                if(containsPattern != containsWord || patternPos != wordPos)
                    return false;

                patternDict[pattern[i].ToString()] = i;
                wordDict[splittedS[i].ToString()] = i;
            }

            return true;
        }

    }
}