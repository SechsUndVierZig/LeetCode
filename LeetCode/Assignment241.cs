using System;
using System.Collections.Generic;
using System.Linq;

public class Assignment241
{
    public class Solution
    {
        public IList<int> DiffWaysToCompute(string expression)
        {
            var cache = new Dictionary<(int, int), List<int>>();
            var numbers = expression.Split("+-*".ToCharArray()).Select(int.Parse).ToArray();
            var ops = expression.Where(c => !Char.IsDigit(c)).ToArray();
            return Compute(0, numbers.Length - 1);
            IList<int> Compute(int start, int end)
            {
                if (cache.TryGetValue((start, end), out var subResult))
                    return subResult;

                subResult = new List<int>();

                if (start == end)
                    subResult.Add(numbers[start]);
                else
                {
                    for (var i = start + 1; i <= end; i++)
                    {
                        var lpart = Compute(start, i - 1);
                        var rpart = Compute(i, end);
                        Func<int, int, int> func = ops[i - 1] switch
                        {
                            '+' => (a, b) => a + b,
                            '-' => (a, b) => a - b,
                            _ => (a, b) => a * b
                        };

                        foreach (var ln in lpart)
                            foreach (var rn in rpart)
                                subResult.Add(func(ln, rn));
                    }
                }
                cache.Add((start, end), subResult);
                return subResult;
            }
        }
    }
}
