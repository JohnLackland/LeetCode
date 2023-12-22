namespace RandomExercises.Easy
{
    //https://leetcode.com/problems/first-bad-version/
    public static class FirstBadVersion
    {
        public static int Logic1(int n)
        {
            int low = 1, high = n;
            var mid = 0;
            while (low <= high)
            {
                mid = low + (high - low) / 2;

                if (!IsBadVersion(mid))
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return mid; // this line should not be reached
        }

        public static int Logic2(int n)
        {
            int low = 1, high = n;
            while (low < high)
            {
                var mid = low + (high - low) / 2;

                if (IsBadVersion(mid))
                    high = mid;
                else
                    low = mid + 1;
            }

            return low; // low and high is merged at this point
        }

        private static bool IsBadVersion(int version)
        {
            // This func is predefined in leetcode, no implementation is needed here
            // Simply returns if the version was good or not
            throw new NotImplementedException();
        }
    }
}