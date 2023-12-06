using RoadmapExercises.LinkedLists.Nodes;

namespace RoadmapExercises.LinkedLists
{
    public static class CopyRandomList
    {
        public static Node Logic1(Node head)
        {
            var current = head;
            var dict = new Dictionary<Node, Node>();
            while (current != null)
            {
                var copy = new Node(current.val);
                dict[current] = copy;
                current = current.next;
            }

            current = head;
            while (current != null)
            {
                var copy = dict[current];
                copy.next = current.next == null ? null : dict[current.next];
                copy.random = current.random == null ? null : dict[current.random];
                current = current.next;
            }
            return dict[head];
        }
    }
}