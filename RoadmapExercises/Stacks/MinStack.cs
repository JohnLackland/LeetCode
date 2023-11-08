namespace RoadmapExercises.Stacks
{
    //https://leetcode.com/problems/min-stack/
    public class MinStack
    {
        private readonly Stack<int> _stack;
        private readonly Stack<int> _minStack;
        public MinStack()
        {
            _stack = new Stack<int>();
            _minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            _stack.Push(val);
            if(_minStack.Count == 0 || val <= _minStack.Peek())
                _minStack.Push(val);
        }

        public void Pop()
        {
            var top = _stack.Pop();
            if(top == _minStack.Peek())
                _minStack.Pop();
        }

        public int Top()
        {
            return _stack.Peek();
        }

        public int GetMin()
        {
            return _minStack.Peek();
        }
    }
}