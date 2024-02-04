using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class MaxVowels
    {
        public static int maxVowelsInString(string s, int k)
        {
            var maxInt = 0;
            var count = 0;

            //Checks for each vowel in first set of k
            for (int i = 0; i < k; i++)
            {
                if (isVowel(s[i]))
                    count++;
            }

            maxInt = count;

            //Moves the window one spot, and then checks if the new count is greater
            for (int j = k; j < s.Length; j++)
            {
                if (isVowel(s[j - k]))
                    count--;
                if (isVowel(s[j]))
                    count++;
                maxInt = Math.Max(maxInt, count);
            }
            return maxInt;
        }

        public static bool isVowel(char c)
        {
            return (c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u');
        }
    }
}
