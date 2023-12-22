using System.ComponentModel.Design;

namespace RandomExercises.Easy
{
    // https://leetcode.com/problems/baseball-game/
    public static class BaseballGame
    {
        public static int Logic1(string[] operations)
        {
            var result = 0;
            var stack = new Stack<int>();
            foreach (var operation in operations)
            {
                if (int.TryParse(operation, out int value))
                {
                    stack.Push(value);
                    continue;
                }

                if (operation == "+")
                {
                    var previousValue = stack.Pop();
                    var newValue = previousValue + stack.Peek();
                    stack.Push(previousValue);
                    stack.Push(newValue);
                }
                else if (operation == "D")
                    stack.Push(stack.Peek() * 2);
                else
                    stack.Pop();
            }

            foreach (var score in stack)
                result += score;

            return result;
        }
    }
}