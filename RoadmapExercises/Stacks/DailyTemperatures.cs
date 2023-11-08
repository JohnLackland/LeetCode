namespace RoadmapExercises.Stacks
{
    //https://leetcode.com/problems/daily-temperatures/
    public static class DailyTemperatures
    {
        public static int[] Logic1(int[] temperatures)
        {
            var result = new int[temperatures.Length];
            var stack = new Stack<int>();

            for (int i = 0; i < temperatures.Length; i++)
            {
                while(stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
                {
                    var tempIndex = stack.Pop();
                    result[tempIndex] = i - tempIndex;
                }
                stack.Push(i);
            }
            return result;
        }
    }
}