using System;

public class Assignment187
{
    public class Solution
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            var dic = new Dictionary<string, int>();
            for (int i = 0; i < s.Length - 9; i++)
            {
                var key = s.Substring(i, 10);
                if (!dic.ContainsKey(key))
                    dic.Add(key, 1);
                else
                    dic[key]++;
            }
            var rs = new List<string>();
            foreach (var item in dic)
                if (item.Value > 1) rs.Add(item.Key);
            return rs;
        }
    }
}
