using System;
using System.Collections.Generic;

namespace StackFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(100);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(1337);
            int mmyStackItem = stack.Pop();
            Console.WriteLine("Top value in the stack is : {0}", mmyStackItem);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());

            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Stack<int> myStack = new Stack<int>();
            Console.WriteLine("The Numbers in the array are: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
                myStack.Push(number);
            }
            Console.WriteLine(" ");
            Console.WriteLine("The number in reverse: ");
            while (myStack.Count > 0)
            {
                int number = myStack.Pop();
                Console.Write(number + " ");
            }

        }


    }
}