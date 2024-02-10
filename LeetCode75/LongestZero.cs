using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class LongestZero
    {
        public static int longestSet(int[] nums, int k)
        {
            int left = 0;
            int curr = 0;
            int ans = 0;
            for(int right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    curr++;
                }

                while(curr > k)
                {
                    if (nums[left] == 0)
                    {
                        curr--;
                    }
                    left++;
                }
                ans = Math.Max(ans, right - left + 1);
            }
            return ans;
        }
    }
}
