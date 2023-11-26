namespace RandomExercises.Easy
{
    //https://leetcode.com/problems/happy-number
    public static class HappyNumber
    {
        public static bool Logic1(int n)
        {
            var hash = new HashSet<int>();
            while (!hash.Contains(n))
            {
                hash.Add(n);
                var temp = 0;
                while (n != 0)
                {
                    var lastDigit = n % 10;
                    temp += lastDigit * lastDigit;
                    n /= 10;
                }
                if(temp == 1)
                    return true;

                n = temp;
            }
            return false;
        }
    }
}