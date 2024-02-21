using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class MinStartValue
    {

        public static int minStartVal (int[] nums)
        {
            var prefix = new int[nums.Length];
            prefix[0] = nums[0];
            var lowestTotal = prefix[0];

            for(int i = 1; i < nums.Length; i++)
            {
                prefix[i] = prefix[i - 1] + nums[i];
                lowestTotal = Math.Min(lowestTotal, prefix[i]);
            }

            if(lowestTotal > 0)
            {
                return 1;
            }

            return Math.Abs(lowestTotal) + 1;
        }

    }
}
