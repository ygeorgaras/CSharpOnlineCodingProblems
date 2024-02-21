using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class GroupAnagrams
    {
        public static IList<IList<string>> getGroupAnagram(string[] strs)
        {

            IList<IList<string>> anagrams = new List<IList<string>>();

            Dictionary <string, IList<string>> groups = new Dictionary<string, IList<string>>();
            foreach(var str in strs)
            {
                var charArray = str.ToCharArray();
                Array.Sort(charArray);
                string key = new string(charArray);

                //Create a List in the dictionary under the key
                if (!groups.ContainsKey(key))
                {
                    groups[key] = new List<string>();
                }
                groups[key].Add(str);

            }

            foreach (var group in groups.Values)
            {
                anagrams.Add(group);
            }

            return anagrams;
        }
    }
}
