namespace RoadmapExercises.Stacks
{
    //https://leetcode.com/problems/valid-parentheses/
    public static class ValidParentheses
    {
        public static bool Logic1(string s)
        {
            var stack = new Stack<char>();
            var map = new Dictionary<char, char>()
            {
                { ')', '('},
                { ']', '['},
                { '}', '{'},
            };

            foreach (var c in s) {
                if (map.TryGetValue(c, out char openPair)) 
                {
                    if (stack.Count == 0 && openPair != stack.Peek())
                        return false;

                    stack.Pop();
                }
                else
                    stack.Push(c);
            }
            return stack.Count == 0;
        }
    }
}