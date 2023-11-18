namespace RandomExercises.Easy
{
    public static class FindIndexFirstOccurrence
    {
        public static int Logic1(string haystack, string needle)
        {
            for (int start = 0; start < haystack.Length - needle.Length; start++)
            {
                if (needle == haystack.Substring(start, start + needle.Length))
                    return start;
            }
            return -1;
        }
    }
}