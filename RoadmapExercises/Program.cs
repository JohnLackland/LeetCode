using RoadmapExercises.ArraysAndHashes;
using RoadmapExercises.Stacks;

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
        }
    }
}