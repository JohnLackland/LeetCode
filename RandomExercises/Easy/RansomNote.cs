namespace RandomExercises.Easy
{
    //https://leetcode.com/problems/ransom-note
    public static class RansomNote
    {
        public static bool Logic1(string ransomNote, string magazine)
        {
            var magazineDict = new Dictionary<char, int>();
            foreach (char c in magazine)
                magazineDict[c] = magazineDict.GetValueOrDefault(c, 0) + 1;

            foreach (var c in ransomNote)
            {
                if(!magazineDict.TryGetValue(c, out int value) || value == 0)
                    return false;

                magazineDict[c]--;
            }
            return true;
        }
    }
}