namespace RoadmapExercises.TwoPointers
{
    //https://leetcode.com/problems/trapping-rain-water/
    public static class TrappingRainWater
    {
        //O(n) space complexity
        public static int Logic1(int[] height)
        {
            var result = 0;
            var highestLeft = new int[height.Length];
            var highestRight = new int[height.Length];


            for (int i = 0; i < height.Length; i++)
            {
                if(i == 0)
                    highestLeft[i] = height[i];
                else
                    highestLeft[i] = Math.Max(height[i], highestLeft[i - 1]);
            };

            for (int i = height.Length - 1; i >= 0; i--)
            {
                if (i == height.Length - 1)
                    highestRight[i] = height[i];
                else
                    highestRight[i] = Math.Max(height[i], highestRight[i + 1]);
            };

            for (int i = 0; i < height.Length; i++)
            {
                var lowerWall = Math.Min(highestLeft[i], highestRight[i]);
                var waterAmount = lowerWall - height[i];
                result += waterAmount > 0 ? waterAmount : 0;
            }

            return result;
        }

         //O(1) space complexity
        public static int Logic2(int[] height)
        {
            var result = 0;
            var left = 0; var right = height.Length - 1;
            var maxleft = height[0];
            var maxright = height[^1];
            while (left < right)
            {
                if (maxleft <= maxright)
                {
                    left++;
                    maxleft = Math.Max(maxleft, height[left]);
                    result += maxleft - height[left];
                }
                else {
                    right--;
                    maxright = Math.Max(maxright, height[right]);
                    result += maxright - height[right];
                }
            }
            return result;
        }
    }
}