using RoadmapExercises.ArraysAndHashes;
using RoadmapExercises.SlidingWindow;
using RoadmapExercises.Stacks;
using RoadmapExercises.TwoPointers;

namespace RoadmapExercises
{
    class Program // This class wraps the Main method
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TopKFrequentElements.Logic2(new int[] { 1, 2 }, 2);
            ProductExpectSelf.Logic1(new int[] { 1, 2, 3, 4 });
            LargestRectangleArea.Logic1(new int[] { 3, 6, 5, 7, 4, 8, 1, 0 });
            SortedTwoSum.Logic1(new int[] { 2, 7, 11, 15 }, 9);
            GenerateParenthesis.Logic1(4);
            TrappingRainWater.Logic1(new int[] { -1, 0, 1, 2, -1, -4 });
            LongestSubstringWithoutRepeatingCharacters.Logic3("pwwkew");
            LongestRepeatingCharacterReplacement.Logic1("AABABBA", 1);
            SlidingWindowMaximum.Logic1(new int[] { 1, -1 }, 1);
        }
    }
}