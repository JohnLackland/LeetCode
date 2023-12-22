namespace RandomExercises.Easy
{
    //https://leetcode.com/problems/guess-number-higher-or-lower/
    public static class GuessTheNumber
    {
        public static int Logic1(int n)
        {
            int low = 1, high = n;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (Guess(mid) < 0)
                    high = mid - 1;
                else if (Guess(mid) > 0)
                    low = mid + 1;
                else
                    return mid;
            }

            return -1; // this line should not be reached
        }

        private static int Guess(int num)
        {
            // This func is predefined in leetcode, no implemenmtation is needed here
            // returns -1 if num is higher than the picked number
            // returns 1 if num is lower than the picked number
            // otherwise return 0
            throw new NotImplementedException();
        }
    }
}