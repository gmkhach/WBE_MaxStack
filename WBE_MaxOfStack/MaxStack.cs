/* 
 * Use the built-in Stack class to implement a new class MaxStack with a method GetMax() that returns the largest element in the stack.
 * GetMax() should not remove the item.
 * Your stacks will contain only integers.
 */

using System;
using System.Collections;
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
