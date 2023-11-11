namespace RoadmapExercises.Stacks
{
    //https://leetcode.com/problems/generate-parentheses/
    public static class GenerateParenthesis
    {
        public static IList<string> Logic1(int n)
        {
            var result = new List<string>();
            HelperFunc(result, "(", 1, 0, n);
            return result;
        }

        private static void HelperFunc(List<string> result, string currentGen, int openCount, int closeCount, int maxPairs)
        {
            if (openCount == closeCount && openCount == maxPairs)
            {
                result.Add(currentGen);
                return;
            }

            if (openCount < maxPairs)
                HelperFunc(result, currentGen + "(", openCount + 1, closeCount, maxPairs);
            if(closeCount < openCount)
                HelperFunc(result, currentGen + ")", openCount, closeCount + 1, maxPairs);
        }
    }
}