using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class LargestUniqueNumber
    {

        public static int getLargestUniqueNumber(int[] nums) 
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            int maxNum = -1;
            foreach (int key in counts.Keys) 
            {
                if (counts[key] == 1)
                {
                    maxNum = Math.Max(maxNum, key);
                }

            }
            return maxNum;
        }

    }
}
