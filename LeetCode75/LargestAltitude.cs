using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class LargestAltitude
    {

        public static int largestAlt(int[] gain)
        {
            int[] prefix = new int[gain.Length];
            prefix[0] = gain[0];
            int highestAlt = Math.Max(0, prefix[0]);

            for(int i = 1; i < gain.Length; i++)
            {
                prefix[i] = prefix[i - 1] + gain[i];
                highestAlt = Math.Max(highestAlt, prefix[i]);
            }

            return highestAlt;
        }

    }
}
