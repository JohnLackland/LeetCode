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

        public static int Logic1(string[] operations)
        {
            var result = 0;
            var firstValueFromBack = 0;
            var secondValueFromBack = 0;
            var thirdValueFromBack = 0;
            for (int i = 0; i < operations.Length; i++)
            {
                if (int.TryParse(operations[i], out int value))
                {
                    thirdValueFromBack = secondValueFromBack;
                    secondValueFromBack = firstValueFromBack;
                    firstValueFromBack = value;
                    result += firstValueFromBack;
                    continue;
                }

                if (operations[i] == "+")
                {
                    var sumOfPreviousTwo = firstValueFromBack + secondValueFromBack;
                    thirdValueFromBack = secondValueFromBack;
                    secondValueFromBack = firstValueFromBack;
                    firstValueFromBack = sumOfPreviousTwo;
                    result += firstValueFromBack;

                }
                else if (operations[i] == "D")
                {
                    thirdValueFromBack = secondValueFromBack;
                    secondValueFromBack = firstValueFromBack;
                    firstValueFromBack = secondValueFromBack * 2;
                    result += firstValueFromBack;
                }
                else
                {
                    result -= firstValueFromBack;
                    firstValueFromBack = secondValueFromBack;
                    secondValueFromBack = thirdValueFromBack;
                }
            }

            return result;
        }
    }
}