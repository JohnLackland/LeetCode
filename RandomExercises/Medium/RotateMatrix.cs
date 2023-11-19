namespace RandomExercises.Medium
{
    //https://leetcode.com/problems/spiral-matrix
    public static class RotateMatrix
    {
        public static void Logic1(int[][] matrix)
        {
            var stack = new Stack<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    stack.Push(matrix[i][j]);
                }
            }

            for (int i = 0; i < matrix.Length; i++)
                for (int j = matrix.Length - 1; j < matrix.Length; j--)
                {
                    matrix[j][i] = stack.Pop();
                }
        }
    }
}