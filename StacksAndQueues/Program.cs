using System;

namespace StacksAndQueues
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("\tWelcome to the Stacks and Queues Data Structure Problems");
            Console.WriteLine("=========================================================================\n");

            Console.WriteLine("Press '1' to perform operations on Stack.");
            Console.WriteLine("Press '2' to perform operations on Queue.");
            Console.Write("Enter Choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CustomStack<int> stack = new CustomStack<int>(); // Creates an instance of the CustomStack class.

                    Console.WriteLine("\tPush Method Call");
                    Console.WriteLine("----------------------------------\n");
                    // Calling Push method to add elements on top of the stack.
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);

                    Console.WriteLine("\n    After Calling Push Method");
                    Console.WriteLine("----------------------------------\n");
                    stack.Display(); // Calling Display method to print all the elements in the stack.

                    Console.WriteLine("\tEmpty Method Call");
                    Console.WriteLine("----------------------------------\n");
                    stack.IsEmpty(); // Calling Empty method to pop out all the elements of the stack.

                    Console.WriteLine("\n    After Calling Empty Method");
                    Console.WriteLine("----------------------------------\n");
                    stack.Display(); // Calling Display method to print stack is empty.
                    break;

                case "2":
                    CustomQueue<int> queue = new CustomQueue<int>();

                    Console.WriteLine("\tEnqueue Method Call");
                    Console.WriteLine("------------------------------------\n");
                    // Calling Enqueue method to add element to the end of queue.
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);

                    Console.WriteLine("\n    After Calling Enqueue Method");
                    Console.WriteLine("------------------------------------\n");
                    queue.Display(); // Calling Display method to print all the elements of the queue.
                    break;

                default:
                    Console.WriteLine("Invalid Choice entered.");
                    break;
            }
        }
    }
}
