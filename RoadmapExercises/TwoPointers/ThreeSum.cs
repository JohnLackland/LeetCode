namespace RoadmapExercises.TwoPointers
{
    //https://leetcode.com/problems/3sum/
    public static class ThreeSum
    {
        public static IList<IList<int>> Logic1(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                var left = i + 1 ; var right = nums.Length;
                while (left < right)
                {
                    var sum = nums[i] + nums[left] + nums[right];
                    if (sum < 0)
                        left++;
                    else if (sum > 0)
                        right--;
                    else
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        left++;
                        while (right > left && nums[left - 1] == nums[left])
                            left++;
                    }
                }
            }
            return result;
        }
    }
}