using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class MaxSumOfPair
    {
        public static int getMaxSumOfPair(int[] nums)
        {
            var MaxSumDic = new Dictionary<int, int>();
            int ans = -1;
            foreach (var num in nums)
            {
                int digitSum = getDigitSum(num);
                if(MaxSumDic.ContainsKey(digitSum))
                {
                    ans = Math.Max(ans, num + MaxSumDic[digitSum]);
                    MaxSumDic[digitSum] = Math.Max(MaxSumDic[digitSum], num);
                }
                else
                {
                    MaxSumDic[digitSum] = num;
                }
            }
            return ans;
        }

        public static int getDigitSum(int num)
        {
            int sum = 0;
            while(num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
