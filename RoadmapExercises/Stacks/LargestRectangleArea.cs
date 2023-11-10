namespace RoadmapExercises.Stacks
{
    //https://leetcode.com/problems/largest-rectangle-in-histogram/
    public static class LargestRectangleArea
    {
        public static int Logic1(int[] heights)
        {
            var stack = new Stack<(int index, int height)>();
            var largestArea = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                var startIndex = i;
                while (stack.Count > 0 && stack.Peek().height > heights[i])
                {
                    var (index, height) = stack.Pop();
                    startIndex = index;
                    largestArea = Math.Max(largestArea, (i - index) * height);
                }

                stack.Push((startIndex, heights[i]));
            }
            while(stack.Count != 0)
            {
                var (index, height) = stack.Pop();
                largestArea = Math.Max(largestArea, (heights.Length - index) * height);
            }
            return largestArea;
        }
    }
}