namespace RandomExercises.Medium
{
    //https://leetcode.com/problems/range-sum-query-2d-immutable/
    public class RangeSum2DQueryImmutable
    {
        private readonly int[,] prefixSums;
        public RangeSum2DQueryImmutable(int[][] matrix)
        {
            prefixSums = new int[matrix.Length + 1, matrix[0].Length + 1];
            for (int row = 0; row < matrix.Length; row++)
            {
                var total = 0;
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    total += matrix[row][column];
                    var prefixColumn = prefixSums[row, column + 1];
                    prefixSums[row + 1, column + 1] = total + prefixColumn;
                }
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            var bottomRight = prefixSums[row2 + 1, col2 + 1];
            var leftColumnArea = prefixSums[row2 + 1, col1];
            var upperArea = prefixSums[row1, col2 + 1];
            var topLeft = prefixSums[row1, col1];

            return bottomRight - leftColumnArea - upperArea + topLeft;
        }
    }
}