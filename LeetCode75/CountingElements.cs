using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class CountingElements
    {
        public static int countElements(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();

            foreach(int x in arr)
            {
                set.Add(x);
            }

            var ans = 0;

            foreach(int x in arr)
            {
                if(set.Contains(x + 1))
                {
                    ans++;
                }
            }

            return ans;

        }
    }
}
