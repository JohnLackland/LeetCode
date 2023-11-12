namespace RoadmapExercises.TwoPointers
{
    //https://leetcode.com/problems/container-with-most-water/
    public static class ContainerWithMostWater
    {
        public static int Logic1(int[] height)
        {
            var maxWater = 0;
            var left = 0;
            var right = height.Length - 1;
            while (left < right)
            {
                maxWater = Math.Max(maxWater, Math.Min(height[left], height[right]) * (right - left));
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }
            return maxWater;
        }

        public static int BruteForce(int[] height)
        {
            var result = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    var areaHight = Math.Min(height[i], height[j]);
                    result = Math.Max(result, (j - i) * areaHight);
                }
            }

            return result;
        }
    }
}