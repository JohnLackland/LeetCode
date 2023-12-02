namespace RoadmapExercises.LinkedLists
{
    //https://leetcode.com/problems/reorder-list/
    public static class ReorderLinkedList
    {
        //Iterative
        public static void Logic1(ListNode head)
        {
            var slow = head;
            var fast = head.next;
            while (fast != null && fast.next != null) 
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            var list2 = slow.next;
            //slow.next = null;
            ListNode prev = null;

            while (list2 != null)
            {
                var temp = list2.next;
                list2.next = prev;
                prev = list2;
                list2 = temp;
            }

            var list1 = head;
            list2 = prev;
            while(list2 != null)
            {
                var temp1 = list1.next;
                var temp2 = list2.next;
                list1.next = list2;
                list2.next = temp1;
                list1 = temp1;
                list2 = temp2;
            }
        }
    }
}