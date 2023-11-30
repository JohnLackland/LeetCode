using System.Xml.Linq;

namespace RandomExercises.Easy
{
    public static class PlusOne
    {
        public static int[] Logic1(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;
        }

    }
}