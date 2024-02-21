using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class CheckIfPangram
    {
        public static bool isPangram(string s)
        {
            HashSet<char> result = new HashSet<char>();

            foreach (char c in s)
            {
                result.Add(c);
            }
            return result.Count == 26;
        }
    }
}
