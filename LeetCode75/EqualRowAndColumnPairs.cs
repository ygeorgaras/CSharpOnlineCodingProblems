using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class EqualRowAndColumnPairs
    {
        public static int getMatchingPairs(int[][] grid) 
        {
            var rows = new Dictionary<string, int>();   
            var columns = new Dictionary<string, int>();

            for(int i = 0; i < grid.Length; i++)
            {
                var rowString = "";
                for(int j = 0; j < grid[i].Length; j++)
                {
                    rowString += grid[i][j] + ',';
                }
                if (rows.ContainsKey(rowString))
                {
                    rows[rowString]++;
                }
                else
                {
                    rows.Add(rowString, 1);
                }
            }

            for(int i = 0; i < grid.Length; i++)
            {
                var colString = "";
                for(int j = 0; j < grid[i].Length; j++)
                {
                    colString += grid[j][i] + ',';
                }
                if (columns.ContainsKey(colString))
                {
                    columns[colString]++;
                }
                else
                {
                    columns.Add(colString, 1);
                }
            }

            int ans = 0;
            foreach(var row in rows)
            {
                foreach(var col in columns)
                {
                    if (row.Key.Equals(col.Key))
                    {
                        ans += row.Value * col.Value;
                    }
                }
            }

            return ans;
        }
    }
}
