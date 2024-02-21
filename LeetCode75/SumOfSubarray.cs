using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class SumOfSubarray
    {
        public static int SubarraySum(int[] nums, int k)
        {
            int count = 0;//total subarrays that equal k
            int sum = 0;//prefix sum of array
            Dictionary<int, int> sumCounts = new Dictionary<int, int>();
            sumCounts[0] = 1; // Initialize with sum 0 having count 1

            foreach (int num in nums)
            {
                sum += num;//inc prefix sum

                /*
                 This works so well because if there is a key that is (sum - k) then know
                 there exists a subarray that adds up to k in the prefix dictionary
                 */
                if (sumCounts.ContainsKey(sum - k))
                {
                    count += sumCounts[sum - k];
                }

                //This will increment the sumCounts values at certain keys
                if (sumCounts.ContainsKey(sum))
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
