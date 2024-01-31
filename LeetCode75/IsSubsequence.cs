using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class IsSubsequence
    {
        public static bool isSubsequence(string s, string t)
        {
            if (string.IsNullOrEmpty(s)) return true;
            if (string.IsNullOrEmpty(t)) return false;

            int sIndex = 0;
            int tIndex = 0;
            while (tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                }
                if (sIndex == s.Length)
                {
                    return true;
                }
                tIndex++;
            }
            if (sIndex != s.Length)
            {
                return false;
            }
            return true;
        }
    }
}
