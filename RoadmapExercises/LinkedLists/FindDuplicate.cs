namespace RoadmapExercises.LinkedLists
{
    //https://leetcode.com/problems/find-the-duplicate-number/
    public static class FindDuplicate
    {
        public static int Logic1(int[] nums)
        {
            var fast = 0;
            var slow = 0;
            while (true)
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
                if (fast == slow)
                    break;
            }

            slow = 0;

            while(slow != fast) 
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return slow;
        }
    }
}