using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomExercises.Medium
{
    public static class NumberOfAvarageSubArray
    {
        //https://leetcode.com/problems/number-of-sub-arrays-of-size-k-and-average-greater-than-or-equal-to-threshold/
        public static int Logic1(int[] arr, int k, int threshold)
        {
            var sum = 0;
            var left = 0;
            var count = 0;
            for (int right = 0; right < arr.Length; right++)
            {
                if (right - left + 1> k)
                {
                    sum -= arr[left];
                    left--;
                }

                sum += arr[right];

                if (right - left == k && sum / 3 >= threshold)
                    count++;
            }

            return count;
        }


        public static int Logic2(int[] arr, int k, int threshold)
        {
            var sum = arr.Take(k - 1).Sum();
            var count = 0;
            for (int l = 0; l < arr.Length - k + 1; l++)
            {
                sum += arr[l + k -1];
                if (sum / k >= threshold)
                    count++;

                sum -= arr[l];
            }

            return count;
        }
    }
}