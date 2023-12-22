namespace RoadmapExercises.BinarySearch
{
    //https://leetcode.com/problems/search-a-2d-matrix/
    public static class SearchMatrix
    {
        // time compexity of O(log(n) + log(m))
        public static bool Logic1(int[][] matrix, int target)
        {
            var targetRowIndex = 0;
            var low = 0;
            var high = matrix.Length - 1;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                if (matrix[mid][0] < target)
                {
                    targetRowIndex = mid;
                    low = mid + 1;
                }
                else if (matrix[mid][0] > target)
                    high = mid - 1;
                else
                    return true;
            }

            low = 0;
            high = matrix[targetRowIndex].Length - 1;
            while(low <= high)
            {
                var mid = low + (high - low) / 2;
                if (matrix[targetRowIndex][mid] > target)
                    high = mid - 1;
                else if (matrix[targetRowIndex][mid] < target)
                    low = mid + 1;
                else
                    return true;
            }

            return false;
        }

        // Slightly better time complexity O(log(m * n))
        public static bool Logic2(int[][] matrix, int target)
        {
            var rowLength = matrix[0].Length;
            var low = 0;
            var high = rowLength * matrix.Length - 1;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                var value = matrix[mid / rowLength][mid % rowLength];

                if (value < target)
                    low = mid + 1;
                else if (value > target)
                    high = mid - 1;
                else
                    return true;
            }

            return false;
        }

    }
}