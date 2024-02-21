using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class ReverseWordsInString
    {
        public static string reverseWords(string s)
        {
            string[] wordList = s.Split(" ");
            string reversedList = string.Empty;
            
            for (int i = wordList.Length-1; i >= 0; i--)
            {
                if (!(string.IsNullOrEmpty(wordList[i])))
                {
                    reversedList += wordList[i] + " ";
                }
            }
            reversedList = reversedList.Trim();
            return reversedList;
        }
    }
}
