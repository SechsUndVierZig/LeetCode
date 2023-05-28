using System;
using System.Collections.Generic;

public class Assignment49
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                char[] arr = strs[i].ToCharArray();
                Array.Sort(arr);
                String sorted = new String(arr);

                if (!dict.ContainsKey(sorted)) dict.Add(sorted, new List<String>() { strs[i] });
                else dict[sorted].Add(strs[i]);

            }
            return dict.Values.ToList();
        }
    }
}
