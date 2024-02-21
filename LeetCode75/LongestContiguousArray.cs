using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class LongestContiguousArray
    {
        public static int getLongestContiguousArray(int[] nums)
        {
            // Dictionary to store the first occurrence of a particular count
            Dictionary<int, int> countIndexMap = new Dictionary<int, int>();
            countIndexMap.Add(0, -1); // Initialize with count 0 at index -1

            int maxLength = 0;
            int count = 0; // Keeps track of the count of 1s and 0s

            for (int i = 0; i < nums.Length; i++)
            {
                // Increase count for 1, decrease for 0
                count += (nums[i] == 1) ? 1 : -1;

                // If the count has been seen before, update maxLength
                if (countIndexMap.ContainsKey(count))
                {
                    maxLength = Math.Max(maxLength, i - countIndexMap[count]);
                }
                else
                {
                    // Store the first occurrence of this count
                    countIndexMap.Add(count, i);
                }
            }

            return maxLength;
        }
    }
}
