using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class LongestSubArray
    {
        public static int LongestSubArrayMinusOne(int[] nums) 
        {
            int left = 0, curr = 0, ans = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    curr++;
                }
                while(curr > 1)
                {
                    if (nums[left] == 0)
                    {
                        curr--;
                    }
                    left++;
                }
                ans = Math.Max(ans, right - left);
            }
            return ans;
        }
    }
}
