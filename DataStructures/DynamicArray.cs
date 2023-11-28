namespace DataStructures
{
    public class DynamicArray
    {
        private int[] _arr;
        private int _lastIndex;

        public DynamicArray(int capacity = 10)
        {
                _arr = new int[capacity];
        }

        public int Get(int index)
        {
            return _arr[index];
        }

        public void Set(int index, int num)
        {
            _arr[index] = num;
        }

        public void Pushback(int n)
        {
            if(_arr.Length - 1 == _lastIndex)
                Resize();
            _arr[++_lastIndex] = n;
        }

        public int Popback()
        {
            int removedNum = _arr[_lastIndex];
            _arr[--_lastIndex] = 0;
            return removedNum;
        }

        public void Resize()
        {
            var resizedArr = new int[_arr.Length * 2];
            Array.Copy(_arr, resizedArr, _lastIndex);
            _arr = resizedArr;
        }

        public int GetSize()
        {
            return _lastIndex + 1;
        }

        public int GetCapacity()
        {
            return _arr.Length;
        }
    }
}