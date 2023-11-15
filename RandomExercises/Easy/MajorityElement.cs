namespace RandomExercises.Easy
{
    //https://leetcode.com/problems/majority-element
    public static class MajorityElement
    {
        public static int Logic1(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                dict[num] = dict.GetValueOrDefault(num, 0) + 1;

                if (dict[num] > nums.Length / 2)
                    return num; 
            }

            // it will be never reached
            return default;
        }
    }
}