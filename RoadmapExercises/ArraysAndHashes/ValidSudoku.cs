namespace RoadmapExercises.ArraysAndHashes
{
    //https://leetcode.com/problems/valid-sudoku/
    public static class ValidSudoku
    {
        public static bool Logic1(char[][] board)
        {
            var rows = new HashSet<char>[9];
            var columns = new HashSet<char>[9];
            var boxes = new HashSet<char>[9];

            for (int i = 0; i < board.Length; i++)
            {
                rows[i] = new HashSet<char>();
                columns[i] = new HashSet<char>();
                boxes[i] = new HashSet<char>();
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    var currentNumber = board[i][j];
                    if (currentNumber == '.')
                        continue;

                    if (rows[i].Contains(currentNumber) || columns[j].Contains(currentNumber) || boxes[(i / 3) * (3 + j) / 3].Contains(currentNumber))
                        return false;

                    rows[i].Add(currentNumber);
                    columns[j].Add(currentNumber);
                    boxes[(i / 3) * 3 + (j / 3)].Add(currentNumber);
                }
            }

            return true;
        }
    }
}