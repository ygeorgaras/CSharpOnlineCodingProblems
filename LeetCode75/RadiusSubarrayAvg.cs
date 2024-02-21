using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


//https://leetcode.com/explore/interview/card/leetcodes-interview-crash-course-data-structures-and-algorithms/703/arraystrings/4836/

namespace CodingProblems.LeetCode75
{
    internal class RadiusSubarrayAvg
    {

        public static int[] GetAverages(int[] nums, int k)
        {
            if (k == 0)
            {
                return nums;
            }

            int windowSize = 2 * k + 1;
            int[] averages = new int[nums.Length];
            Array.Fill(averages, -1);

            if (windowSize > nums.Length)
            {
                return averages;
            }

            //We make the prefix array 1 longer to store 0 at the first index.
            long[] prefix = new long[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                prefix[i + 1] = prefix[i] + nums[i];
            }

            for (int i = k; i < (nums.Length - k); i++)
            {
                int leftBound = i - k;
                int rightBound = i + k;
                long subArraySum = prefix[rightBound + 1] - prefix[leftBound];
                int average = (int)(subArraySum / windowSize);
                averages[i] = average;
            }

            return averages;
        }

    }
}

//if (k == 0)
//    return nums;
//long[] prefix = new long[nums.Length]; 
//prefix[0] = nums[0];
//int[] returnArray = new int[nums.Length];
//Console.WriteLine(prefix[0]);

//for (int i = 1; i < nums.Length; i++)
//{
//    prefix[i] = prefix[i - 1] + nums[i];
//}

//int divisor = k * 2 + 1;

//for (int i = 0; i < nums.Length; i++)
//{
//    if(i < k || (i + k) >= nums.Length)
//    {
//        returnArray[i] = -1;
//    }
//    else
//    {
//        if(i-k == 0)
//        {
//            returnArray[i] = (int)(prefix[i + k] / divisor);
//        }
//        else
//        {
//            returnArray[i] = ((int)((prefix[i + k] - prefix[i - k - 1]) / divisor));
//        }
//    }
//}

//return returnArray;
