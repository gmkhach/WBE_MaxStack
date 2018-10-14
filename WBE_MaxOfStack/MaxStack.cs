using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_MaxOfStack
{
    class MaxStack : Stack<int>
    {
        public int GetMax(Stack<int> myStack)
        {
            int max = myStack.Peek();
            foreach (var x in myStack)
            {
                max = x > max ? x : max;
            }
            return max;
        }
    }
}
