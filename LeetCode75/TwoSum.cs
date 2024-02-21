using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class TwoSum
    {
        public static int[] GetTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++) {
                int compliment = target - nums[i];
                if (dic.ContainsKey(compliment))
                {
                    return new int[] { dic[compliment], i };
                }

                if (!dic.ContainsKey(nums[i])){
                    dic.Add(nums[i], i);
                }
            }
            return new int[]{-1, -1};
        }
    }
}
