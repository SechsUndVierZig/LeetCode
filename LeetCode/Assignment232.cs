using System;
using System.Collections.Generic;

public class Assignment232
{
    public class MyQueue
    {

        private Stack<int> Stack;
        private Stack<int> StackToImpelemnt;
        public MyQueue()
        {
            Stack = new Stack<int>();
            StackToImpelemnt = new Stack<int>();
        }

        public void Push(int x)
        {
            Stack.Push(x);
        }

        public int Pop()
        {
            while (Stack.Count > 0)
            {
                StackToImpelemnt.Push(Stack.Pop());
            }
            int poppedOut = StackToImpelemnt.Pop();
            while (StackToImpelemnt.Count > 0)
            {
                Stack.Push(StackToImpelemnt.Pop());
            }
            return poppedOut;
        }

        public int Peek()
        {
            while (Stack.Count > 0)
            {
                StackToImpelemnt.Push(Stack.Pop());
            }
            int peek = StackToImpelemnt.Peek();
            while (StackToImpelemnt.Count > 0)
            {
                Stack.Push(StackToImpelemnt.Pop());
            }
            return peek;
        }

        public bool Empty()
        {
            return Stack.Count == 0;
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
