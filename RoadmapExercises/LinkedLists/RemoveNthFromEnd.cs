using RoadmapExercises.LinkedLists.Nodes;

namespace RoadmapExercises.LinkedLists
{
    public static class RemoveNthFromEnd
    {
        public static ListNode Logic1(ListNode head, int n)
        {
            var dummy = new ListNode(0, head);
            var first = dummy;
            var second = head;
            for (int i = 0; i < n; i++)
            {
                second = second.next;
            }

            while (second != null)
            {
                first = first.next;
                second = second.next;
            }

            first.next = first.next.next;
            return dummy.next;
        }
    }
}