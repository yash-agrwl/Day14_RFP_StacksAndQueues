using System;

namespace StacksAndQueues
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("\tWelcome to the Stacks and Queues Data Structure Problems");
            Console.WriteLine("=========================================================================\n");

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
        }
    }
}
