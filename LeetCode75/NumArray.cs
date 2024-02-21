using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class NumArray
    {
        private int[] rangeSum;
        public NumArray(int[] nums)
        {
            rangeSum = new int[nums.Length];
            rangeSum[0] = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                rangeSum[i] = rangeSum[i-1] + nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            if(left == 0)
            {
                return rangeSum[right];
            }

            return rangeSum[right] - rangeSum[left-1];

        }
    }
}
