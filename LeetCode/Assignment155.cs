using System;
using System.Collections.Generic;

public class Assignment155
{
    public class MinStack
    {
        Stack<int> stack = null;
        Stack<int> minimumStack = null;
        public MinStack()
        {
            stack = new Stack<int>();
            minimumStack = new Stack<int>();
        }

        public void Push(int val)
        {
            if (minimumStack.Count > 0)
            {
                int minimumValue = minimumStack.Peek();
                if (minimumValue >= val)
                {
                    minimumStack.Push(val);
                }
            }
            else
            {
                minimumStack.Push(val);
            }
            stack.Push(val);
        }

        public void Pop()
        {
            int val = 0;
            val = stack.Pop();
            if (minimumStack.Count > 0 && val == minimumStack.Peek())
            {
                minimumStack.Pop();
            }
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minimumStack.Peek();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
