using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class MaximumAverageSubarray
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            double sum = 0;
            //Set the base sum
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }

            double maxAverage = sum / k;
            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];//Moves window one spot each time and updates sum
                maxAverage = Math.Max(maxAverage, sum / k);//Checks if maxAverage is larger than sum / k. If not then replace
            }

            return maxAverage;
        }
    }
}