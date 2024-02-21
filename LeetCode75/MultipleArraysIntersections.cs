using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class MultipleArraysIntersections
    {
        public static IList<int> Intersection(int[][] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int[] arr in nums)
            {
                foreach(int i in arr)
                {
                    if (counts.ContainsKey(i))
                    {
                        counts[i]++;
                    }
                    else
                    {
                        counts.Add(i, 1);
                    }
                }
            }

            List<int> ans = new List<int>();
            foreach (int key in counts.Keys)
            {
                if (counts[key] == nums.Length)
                {
                    ans.Add(key);
                }
            }

            ans.Sort();

            return ans;
        }
    }
}
