using System;
using System.Collections;

namespace QueueFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("EnQueue and Dequeue");

            Queue myQueue = new Queue();
            for (int i = 0; i <= 10; i++)  
            {                          
                myQueue.Enqueue(i);
                Console.WriteLine(i + " ");
                Console.WriteLine($"Number of Elements = {myQueue.Count}");
            }
            while(myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
                Console.WriteLine($"Number of Elements = {myQueue.Count}");
            }

        }
    }
}