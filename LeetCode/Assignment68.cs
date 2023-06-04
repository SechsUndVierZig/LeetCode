using System;

public class Assignment68
{
    public class Solution
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<string> ret = new();
            int thisLen = 0, totLen = 0, cnt = 0, start = 0;
            string s;
            StringBuilder sb = new(maxWidth);
            for (int i = 0; i <= words.Length; i++)
            {
                bool last = i == words.Length;
                if (!last)
                {
                    thisLen = words[i].Length;
                    if (thisLen + totLen + cnt <= maxWidth)
                    {
                        totLen += thisLen;
                        cnt++;
                        continue;
                    }
                }
                if (last || cnt == 1 || totLen + cnt - 1 == maxWidth)
                {
                    s = string.Join(' ', words, start, cnt);
                    if ((last || cnt == 1) && s.Length < maxWidth) s = s.PadRight(maxWidth, ' ');
                }
                else
                {
                    int totGap = maxWidth - totLen;
                    int extra = totGap % (cnt - 1);
                    int gap = totGap / (cnt - 1);
                    for (int j = start; j < start + cnt; j++)
                    {
                        sb.Append(words[j]);
                        if (j < start + cnt - 1)
                        {
                            int thisGap = gap;
                            if (extra > 0) { thisGap++; extra--; }
                            sb.Append(new string(' ', thisGap));
                        }
                    }
                    s = sb.ToString(); sb.Clear();
                }
                ret.Add(s);
                if (!last)
                {
                    start = i;
                    cnt = 1;
                    totLen = thisLen;
                }
            }
            return ret;
        }
    }
}
