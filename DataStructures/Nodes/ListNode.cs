namespace DataStructures.Nodes
{
    public class ListNode(int val, ListNode next = null)
    {
        public int Val { get; set; } = val;
        public ListNode Next { get; set; } = next;
    }

    public class DoubleListNode(int val, DoubleListNode next = null, DoubleListNode prev = null)
    {
        public int Val { get; set; } = val;
        public DoubleListNode Next { get; set; } = next;
        public DoubleListNode Prev { get; set; } = prev;
    }
}