using System;
using System.Collections.Generic;

public class Assignment60
{
    public class Solution
    {
        private int factorial(int n)
        {
            if (n == 1) return 1;
            else return n * factorial(n - 1);
        }
        private string backtracking(int N, int K, List<int> set, string permutation)
        {
            if (N == 0) return permutation;

            int fact = factorial(N),
                combinations = fact / N,
                index = 0;

            int[] windows = new int[N];
            for (int i = 0, c = combinations; i < N; i++, c += combinations)
            {
                windows[i] = c;
                index += (K > c) ? 1 : 0;
            }

            permutation += set[index];
            set.RemoveAt(index);
            K -= (index > 0) ? windows[index - 1] : index;
            return backtracking(N - 1, K, set, permutation);
        }

        public string GetPermutation(int n, int k)
        {
            List<int> set = new List<int>();
            for (int i = 1; i <= n; i++) set.Add(i);
            return backtracking(n, k, set, "");
        }
    }
}
