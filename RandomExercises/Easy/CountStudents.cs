namespace RandomExercises.Easy
{
    //https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/solutions/
    public static class CountStudents
    {
        public static int Logic1(int[] students, int[] sandwiches)
        {
            var studentQueue = new Queue<int>();
            var sandwichStack = new Stack<int>();

            for (int i = 0; i < students.Length; i++)
            {
                studentQueue.Enqueue(students[i]);
                sandwichStack.Push(sandwiches[sandwiches.Length - 1 - i]);
            }

            var studentsCouldEat = true;
            while (studentsCouldEat)
            {
                studentsCouldEat = false;
                for (int i = 0; i < studentQueue.Count; i++)
                {
                    var currStudent = studentQueue.Dequeue();

                    if (currStudent == sandwichStack.Peek())
                    { 
                        sandwichStack.Pop();
                        studentsCouldEat = true;
                    }
                    else
                        studentQueue.Enqueue(currStudent);
                }
            }

            return studentQueue.Count;
        }
    }
}