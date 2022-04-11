using System;

namespace StacksAndQueues
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Stacks and Queues Data Structure Problems.\n");

            CustomStack<int> stack = new CustomStack<int>(); //Creates an instance of the CustomStack class.

            //Calling Push method to add elements on top of the stack.
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            //Calling Display method to print all the elements in the stack.
            stack.Display();
        }
    }
}
