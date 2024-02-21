using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class EqualNumOccurrences
    {
        public static bool AreEqualOccurances(string s) 
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach(char c in s)
            {
                if(!counts.TryAdd(c, 1))
                {
                    counts[c] += 1;
                }
            }

            HashSet<int> result = new HashSet<int>(counts.Values);
            


            return result.Count == 1;
        }
    }
}
