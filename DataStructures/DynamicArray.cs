namespace DataStructures
{
    public class DynamicArray(int capacity = 10)
    {
        private int[] _arr = new int[capacity];
        private int _length = 0;
        private int _capacity = capacity;

        public int Get(int index)
        {
            return _arr[index];
        }

        public void Set(int index, int num)
        {
            _arr[index] = num;
        }

        public void PushBack(int n)
        {
            if (_length == _capacity)
                Resize();

            _arr[_length] = n;
            _length++;
        }

        public int PopBack()
        {
            if (_length > 0)
            {
                int removedNum = _arr[_length - 1];
                _arr[_length - 1] = 0;
                _length--;
                return removedNum;
            }
            return _arr[0];
        }

        public void Resize()
        {
            _capacity *= 2;
            int[] newArr = new int[_capacity];
            for (int i = 0; i < _length; i++)
            {
                newArr[i] = _arr[i];
            }
            _arr = newArr;
        }

        public int GetSize()
        {
            return _length;
        }

        public int GetCapacity()
        {
            return _capacity;
        }
    }
}