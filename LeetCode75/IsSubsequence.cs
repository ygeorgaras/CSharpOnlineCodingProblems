using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class IsSubsequence
    {
        
        //Cleaner version
        public static bool isSubsequence(string s, string t)
        {
            int i = 0;
            int j = 0;
            
            while(i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
                j++;
            }

            return i == s.Length;
        }

        //public static bool isSubsequence(string s, string t)
        //{
        //    if (string.IsNullOrEmpty(s)) return true;
        //    if (string.IsNullOrEmpty(t)) return false;

        //    int sIndex = 0;
        //    int tIndex = 0;
        //    while (tIndex < t.Length)
        //    {
        //        if (s[sIndex] == t[tIndex])
        //        {
        //            sIndex++;
        //        }
        //        if (sIndex == s.Length)
        //        {
        //            return true;
        //        }
        //        tIndex++;
        //    }
        //    if (sIndex != s.Length)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}
