namespace RoadmapExercises.LinkedLists
{
    //https://leetcode.com/problems/reverse-linked-list/
    public static class ReverseLinkedList
    {
        //Iterative
        public static ListNode Logic1(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            while (curr != null)
            {
                var temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            return prev;
        }

        //Recursive
        public static ListNode Logic2(ListNode head)
        {
            if (head.next == null)
            {
                return head;
            }

            ListNode newHead = Logic2(head.next);
            head.next.next = head;
            return newHead;
        }
    }
}