namespace RoadmapExercises.TwoPointers
{
    //https://leetcode.com/problems/trapping-rain-water/
    public static class TrappingRainWater
    {
        //O(n) space complexity
        public static int Logic1(int[] height)
        {
            var result = 0;

            return result;
        }

        //O(1) space complexity
        public static int Logic2(int[] height)
        {
            var result = 0;
            var leftHighest = height[0];
            var rightHighest = height[^1];
            var left = 0;
            var right = height.Length - 1;
            while (left < right)
            {
                if (rightHighest >= leftHighest)
                {
                    result += Math.Max(0, leftHighest - height[left]);
                    leftHighest = Math.Max(leftHighest, height[left]);
                    left++;    
                }
                else
                { 
                    result += Math.Max(0, rightHighest - height[right]);
                    rightHighest = Math.Max(rightHighest, height[right]);
                    right--;
                }
            }

            return result;
        }
    }
}