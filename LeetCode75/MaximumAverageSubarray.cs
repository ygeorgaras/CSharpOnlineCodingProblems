using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public static bool[] answerQueries(int[] nums, int[][] queries, int limit)
        {
            int[] prefix = new int[nums.Length];
            prefix[0] = nums[0];
            Console.Write(prefix[0] + " ");

            for (int i = 1; i < nums.Length; i++)
            {
                prefix[i] = prefix[i - 1] + nums[i];
                Console.Write(prefix[i] + " ");
            }
            Console.WriteLine("");
            bool[] ans = new bool[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int x = queries[i][0], y = queries[i][1];
                int curr = prefix[y] - prefix[x] + nums[x];
                ans[i] = curr < limit;
                Console.WriteLine(curr + " ");
            }

            return ans;
        }
    }
}