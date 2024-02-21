using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class MissingNumberHashSet
    {
        public static int MissingNumber(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            
            foreach(int num in nums) 
            { 
                result.Add(num);
            }

            for(int i = 0; i < nums.Length + 1; i++)
            {
                if (!result.Contains(i))
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
