using RoadmapExercises.LinkedLists.Nodes;

namespace RoadmapExercises.LinkedLists
{
    //https://leetcode.com/problems/add-two-numbers
    public static class AddTwoNumbers
    {
        public static ListNode Logic1(ListNode l1, ListNode l2)
        {
            var dummy = new ListNode(int.MinValue);
            var curr = dummy;

            var carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            { 
                var nodeSum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
                carry = nodeSum / 10;
                curr.next = new ListNode(nodeSum % 10);

                curr = curr.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            return dummy.next;
        }
    }
}