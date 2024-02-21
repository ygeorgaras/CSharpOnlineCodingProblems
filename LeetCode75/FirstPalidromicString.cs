using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class FirstPalidromicString
    {
        public static string FirstPalindrome(string[] words)
        {

            foreach (var word in words) {
                int left = 0;
                int right = word.Length - 1;
                if(word.Length == 1)
                {
                    return word;
                }
                while (left < right)
                {
                    if (word[left] != word[right])
                    {
                        break;
                    }
                    left++;
                    right--;
                    if(left >= right)
                    {
                        return word;
                    }
                }
            }

            return "";
        }
    }
}
