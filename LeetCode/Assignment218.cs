using System;
using System.Collections.Generic;

public class Assignment218
{
    public class Solution
    {

        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            var ret = new List<IList<int>>();

            HashSet<int> x = new();

            for (int i = 0; i < buildings.Length; i++)
            {
                x.Add(buildings[i][0]);
                x.Add(buildings[i][1]);
            }

            var xcoords = x.ToList();
            xcoords.Sort();

            int lastH = 0;
            for (int i = 0; i < xcoords.Count - 1; i++)
            {
                var s = xcoords[i];
                var e = xcoords[i + 1];

                int maxH = 0;
                for (int b = 0; b < buildings.Length; b++)
                    if (buildings[b][2] > maxH && buildings[b][1] > s && buildings[b][0] < e)
                        maxH = buildings[b][2];

                if (i == 0 || lastH != maxH)
                    ret.Add(new List<int>() { s, maxH });

                lastH = maxH;
            }

            // add terminal point
            ret.Add(new List<int> { xcoords[xcoords.Count - 1], 0 });

            return ret;
        }
    }
}
