namespace DataStructures
{
    public class Stack <T>
    {
        private readonly List<T> values;

        public Stack()
        {
            values = [];
        }

        public void Push(T value)
        {
            values.Add(value);
        }

        public T Pop()
        {
            if (values.Count > 0)
            {
                var topValue = values[^1];
                values.RemoveAt(values.Count - 1);
                return topValue;
            }

            return default;
        }

        public int Size()
        {
            return values.Count;
        }
    }
}