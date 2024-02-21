using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class PivotIndex
    {
        public static int findPivotIndex(int[] nums)
        {
            int[] prefix = new int[nums.Length];
            prefix[0] = nums[0];
            int total = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                prefix[i] = prefix[i - 1] + nums[i];
                total += nums[i];
            }

            if (prefix[0] == total)
            {
                return 0;
            }

            for(int i = 1; i < nums.Length; i++)
            {
                int leftSide = prefix[i - 1];
                int rightSide = total - prefix[i];

                if(leftSide == rightSide)
                {
                    return i;
                }

            }

            return -1;
        }
    }
}
