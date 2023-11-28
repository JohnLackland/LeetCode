namespace RoadmapExercises.LinkedLists
{
    //https://leetcode.com/problems/merge-two-sorted-lists/
    public static class LinkedListCycle
    {
        //Iterative - Space O(n)
        public static bool Logic1(ListNode head)
        {
            var hash = new HashSet<ListNode>();
            while (head.next != null)
            {
                if (hash.Contains(head))
                    return true;

                hash.Add(head);
                head = head.next;
            }
            return false;
        }

        // Iterative - Floyd's algo - Space O(n)
        public static bool Logic2(ListNode head)
        {
            if (head == null)
                return false;

            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return true;
            }
            return false;
        }
    }
}