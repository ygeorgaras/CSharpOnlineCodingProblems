using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class MaxOperations
    {   
        public static int maxOper(int[] nums, int k)
        {
            Array.Sort(nums);
            int count = 0;
            int i = 0;
            int j = nums.Length - 1;

            while(i < j) {
                int sum = 0;
                sum = nums[i] + nums[j];
                
                if (sum < k)
                {
                    i++;//If the sum is less than k, increment the low end of the array
                }
                else if(sum > k)
                {
                    j--;//If the sum is greater than k, decrement the high end of the array
                }
                else
                {
                    //Since we found a match we need to adjust the values accordingly
                    i++;
                    j--;
                    count++;
                }
            }
            return count;
        }
    }
}
