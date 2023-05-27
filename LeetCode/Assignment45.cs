using System;

public class Assignment45
{
    public class Solution
    {
        public int Jump(int[] nums)
        {
            int[] res = new int[nums.Length];

            for (int i = 1; i < res.Length; i++)
                res[i] = JumpAux(nums, res, i);
            return res[res.Length - 1];
        }


        public int JumpAux(int[] nums, int[] res, int index)
        {
            if (index == 0)
                return 0;

            if (res[index] > 0)
                return res[index];
            int minJump = int.MaxValue;
            for (int i = 0; i < index; i++)
                if (nums[i] + i >= index)
                    if (res[i] + 1 < minJump)
                        minJump = res[i] + 1;
            return minJump;
        }

    }
}
