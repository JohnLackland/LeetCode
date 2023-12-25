namespace RoadmapExercises.BinarySearch
{
    //https://leetcode.com/problems/koko-eating-bananas/
    public static class KokosBanana
    {
        public static int MinEatingSpeed(int[] piles, int h)
        {
            var low = 1;
            var high = piles.Max();
            var result = high;

            if (piles.Length == h)
                return high;

            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                long hoursToFinish = 0;

                foreach (var p in piles)
                    hoursToFinish += (int)Math.Ceiling((double)p / mid);

                if (hoursToFinish <= h)
                {
                    result = mid;
                    high = mid - 1;
                }
                else
                    low = mid + 1;
            }

            return result;
        }
    }
}