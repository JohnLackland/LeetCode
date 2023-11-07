namespace RoadmapExercises.ArraysAndHashes
{
    //https://leetcode.com/problems/product-of-array-except-self/
    public static class ProductExpectSelf
    {
        public static int[] Logic1(int[] nums)
        {
            var leftProducts = new int[nums.Length];
            leftProducts[0] = 1;
            var rightProducts = new int[nums.Length];
            rightProducts[nums.Length - 1] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                leftProducts[i] = nums[i - 1] * leftProducts[i - 1];
                rightProducts[nums.Length - 1 - i] = nums[nums.Length - i] * rightProducts[nums.Length - i];
            }

            var result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
                result[i] = leftProducts[i] * rightProducts[i];

            return result;
        }

        // Space complexity O(1)
        public static int[] Logic2(int[] nums)
        {
            var result = new int[nums.Length];
            result[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = nums[i - 1] * result[i - 1];
            }

            var numToTheRight = 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= numToTheRight;
                numToTheRight *= nums[i];
            }

            return result;
        }
    }
}