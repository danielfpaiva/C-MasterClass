using System;
using System.Collections.Generic;

namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // defines the Stack
            Stack<int> stack = new Stack<int>();

            // adding item to the stack
            stack.Push(1);
            Console.WriteLine("First element is {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("First element is {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("First element is {0}", stack.Peek());

            // remove item from stack
            int myStackItem = stack.Pop();
            Console.WriteLine("Poped element {0}", myStackItem);

            while (stack.Count > 0)
            {
                Console.WriteLine("The value removed was {0}", stack.Pop());
                Console.WriteLine("The current stack is {0}", stack.Count);
            }

            int[] array = { 8, 2, 3, 4, 7, 6, 2 };
            Stack<int> numberStack = new Stack<int>();

            foreach (int number in array)
            {
                numberStack.Push(number);
            }

            while (numberStack.Count > 0)
            {
                int number = numberStack.Pop();
                Console.WriteLine(number + " ");
            }
            
        }
    }
}
