namespace RandomExercises.Medium
{
    //https://leetcode.com/problems/set-matrix-zeroes
    public static class SetMatrixZeroes
    {
        public static void Logic1(int[][] matrix)
        {
            var rows = new HashSet<int>();
            var cloumns = new HashSet<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {

                    if (matrix[i][j] != 0)
                        continue;

                    rows.Add(i);
                    cloumns.Add(j);
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (rows.Contains(i) || cloumns.Contains(j))
                        matrix[i][j] = 0;
                }
            }
        }
    }
}