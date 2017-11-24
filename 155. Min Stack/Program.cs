using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _155.Min_Stack
{
    public class MinStack
    {
        private Stack<int> Stack { set; get; }
        /** initialize your data structure here. */
        public MinStack()
        {
            Stack = new Stack<int>();
        }

        public void Push(int x)
        {
            Stack.Push(x);
        }

        public void Pop()
        {
            Stack.Pop();
        }

        public int Top()
        {
            return Stack.Peek();
        }

        public int GetMin()
        {
            return Stack.Min();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
