using DataStructures.Nodes;

namespace DataStructures
{
    public class Queue
    {
        private DoubleListNode dummyHead;
        private DoubleListNode dummyTail;

        public Queue()
        {
            dummyHead = new DoubleListNode(0);
            dummyTail = new DoubleListNode(0);
            dummyHead.Next = dummyTail;
            dummyTail.Prev = dummyHead;
        }

        public bool IsEmpty()
        {
            return dummyHead.Next == dummyTail;
        }

        public void Append(int value)
        {
            var newNode = new DoubleListNode(value)
            {
                Prev = dummyTail.Prev,
                Next = dummyTail
            };
            dummyTail.Prev.Next = newNode;
            dummyTail.Prev = newNode;
        }

        public void appendleft(int value)
        {
            var newNode = new DoubleListNode(value)
            {
                Next = dummyHead.Next,
                Prev = dummyHead
            };
            dummyHead.Next.Prev = newNode;
            dummyHead.Next = newNode;
        }

        public int Pop()
        {
            if (IsEmpty())
                return -1;

            var targetNode = dummyTail.Prev;
            targetNode.Prev.Next = dummyTail;
            dummyTail.Prev = targetNode.Prev;
            return targetNode.Val;
        }

        public int Popleft()
        {
            if (IsEmpty())
                return -1;

            var targetNode = dummyHead.Next;
            dummyHead.Next = targetNode.Next;
            targetNode.Next.Prev = dummyHead;
            return targetNode.Val;
        }
    }
}
