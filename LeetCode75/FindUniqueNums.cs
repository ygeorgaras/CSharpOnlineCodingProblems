using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class FindUniqueNums
    {
        public static List<int> FindNumbers(int[] nums)
        {
            
            HashSet<int> result = new HashSet<int>();
            List<int> numbers = new List<int>();

            foreach (int num in nums)
            {
                result.Add(num);
            }

            foreach (int num in nums)
            {
                if(!result.Contains(num+1) && !result.Contains(num - 1)){
                    numbers.Add(num);
                }
            }

            return numbers;
        }
    }
}
