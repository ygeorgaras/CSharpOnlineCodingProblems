using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class ReverseVowelOfString
    {
        //Reverses only vowels in a string
        public static string reverseVowels(string s)
        {
            var cArray = new List<char>();
            string newString = string.Empty;

            foreach (var c in s)
            {
                if("aeiouAEIOU".Contains(c))
                {
                    cArray.Add(c);
                }
            }

            int cArrayLength = cArray.Count;

            for(int i = 0; i < s.Length; i++)
            {
                if ("aeiouAEIOU".Contains(s[i]))
                {
                    newString += cArray[cArrayLength - 1];
                    cArrayLength--;
                }
                else
                {
                    newString += s[i];
                }
            }
            return newString;
        }
    }
}
