using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class MergeAlternately
    {
        public static string mergeAlternately(string word1, string word2)
        {
            //Finds the max length
            int maxLength = (word1.Length > word2.Length) ? word1.Length : word2.Length;
            string merged = string.Empty;
            for (int i = 0; i <= maxLength - 1; i++)
            {
                if(i < word1.Length)
                {
                    merged += word1[i];
                }

                if(i < word2.Length)
                {
                    merged += word2[i];
                }
            }
            return merged;
        }
    }
}
