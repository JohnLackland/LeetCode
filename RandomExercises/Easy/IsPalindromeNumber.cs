using System.Xml.Linq;

namespace RandomExercises.Easy
{
    public static class IsPalindromeNumber
    {
        public static bool Logic1(int x)
        {
            var reversedNumber = 0;
            var temp = x;
            while (temp > 0)
            { 
                var lastDigit = temp % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                temp /= 10;
            }
            return reversedNumber == x;
        }

    }
}