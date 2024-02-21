using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class SortedSquared
    {
        public static int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int) Math.Pow(nums[i], 2);
            }

            for(int i  = 0; i < nums.Length; i++)
            {
                int nextIndex = i + 1;

                while(nextIndex < nums.Length)
                {
                    
                }
                
            }

            return nums;
        }
    }
}
