using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadmapExercises.LinkedLists
{
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
            var temp = head.next;
            
            return Logic1(head);
        }

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}