using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class NumOfNiceSubarray
    {
        public static int NumberOfSubarrays(int[] nums, int k)
        {
            Dictionary<int, int> sumCounts = new Dictionary<int, int>();
            sumCounts[0] = 1;
            int count = 0;
            int sum = 0;// like CURR

            foreach(int num in nums)
            {
                sum += num % 2;//Increment the number of odd numbers
                if (sumCounts.ContainsKey(sum - k))
                {
                    count += sumCounts[sum - k];
                }

                if(sumCounts.ContainsKey(sum))
                {
                    sumCounts[sum]++;
                }
                else
                {
                    sumCounts[sum] = 1;
                }
            }

            return count;
        }
    }
}
