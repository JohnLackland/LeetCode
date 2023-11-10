namespace RoadmapExercises.Stacks
{
    //https://leetcode.com/problems/evaluate-reverse-polish-notation/
    public static class EvaluateReversePolishNotation
    {
        public static int Logic1(string[] tokens)
        {
            var stack = new Stack<int>();
            foreach (var token in tokens)
            {
                switch (token)
                {
                    case "+":
                        stack.Push(stack.Pop() + stack.Pop());
                        break;

                    case "-":
                        {
                            var firstNum = stack.Pop();
                            stack.Push(stack.Pop() - firstNum);
                            break;
                        }
                    case "*":
                        stack.Push(stack.Pop() * stack.Pop());
                        break;

                    case "/":
                        {
                            var firstNum = stack.Pop();
                            stack.Push(stack.Pop() / firstNum);
                            break;
                        }
                    default:
                        stack.Push(Int32.Parse(token));
                        break;
                }
            }
            return stack.Peek();
        }
    }
}