using System.Text;

namespace RoadmapExercises.TwoPointers
{
    //https://leetcode.com/problems/valid-palindrome/
    public static class ValidPalindrome
    {
        public static bool Logic1(string s)
        {
            var removedNonAlphaNumericChars = s.Where(char.IsLetterOrDigit).ToArray();
            var left = 0;
            var right = removedNonAlphaNumericChars.Length - 1;

            while (left < right)
            {
                if (char.ToLower(removedNonAlphaNumericChars[left]) != char.ToLower(removedNonAlphaNumericChars[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }

        public static bool Logic2(string s)
        {
            var strBuilder = new StringBuilder();
            foreach (var c in s)
            {
                if (char.IsLetterOrDigit(c))
                    strBuilder.Append(char.ToLower(c));
            }

            var clearedStr = strBuilder.ToString();
            for (var i = 0; i < clearedStr.Length / 2; i++)
            {
                if (clearedStr[i] != clearedStr[clearedStr.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}