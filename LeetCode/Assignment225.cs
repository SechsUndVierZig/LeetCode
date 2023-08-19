using System;
using System.Collections.Generic;

public class Assignment225
{
    public class MyStack
    {

        private Queue<int> q = new();

        public void Push(int x)
        {
            q.Enqueue(x);
            for (int i = 0; i < q.Count - 1; i++)
                q.Enqueue(q.Dequeue());
        }

        public int Pop() => q.Dequeue();
        public int Top() => q.Peek();
        public bool Empty() => q.Count == 0;
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}
