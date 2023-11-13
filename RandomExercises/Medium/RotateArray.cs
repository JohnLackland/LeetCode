namespace RandomExercises.Medium
{
    //https://leetcode.com/problems/rotate-array
    public static class RotateArray
    {
        public static void Logic1(int[] nums, int k)
        {
            k %= nums.Length;
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        private static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                var temp = arr[end];
                arr[end] = arr[start];
                arr[start] = temp;
                start++;
                end--;
            }
        }
    }
}