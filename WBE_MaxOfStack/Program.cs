/* Use the built-in Stack class to implement a new class MaxStack with a method GetMax() that returns the largest element in the stack.
 * GetMax() should not remove the item.
 * Your stacks will contain only integers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WBE_MaxOfStack
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nEnter an integer between 1 and 100\n\n>>> ");
                    int[] input = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();
                    MaxStack myStack = new MaxStack();
                    foreach (var x in input)
                    {
                        myStack.Push(x);
                    }
                    Console.WriteLine("\nThe highest value in the stack is: " + myStack.GetMax(myStack));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another floor...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }
    }
}
