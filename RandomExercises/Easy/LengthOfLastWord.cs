namespace RandomExercises.Easy
{
    public static class LengthOfLastWord
    {
        public static int Logic1(string s)
        {
            return s.Split(' ').Last(s => !string.IsNullOrWhiteSpace(s)).Length;
        }
    }
}