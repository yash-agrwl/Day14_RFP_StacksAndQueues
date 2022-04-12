using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    /// <summary>
    /// Represents a first-in-first-out(FIFO) collection of instances of the same specified type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class CustomQueue<T>
    {
        /// <summary>
        /// A node class reference pointing to the first element of the queue or null if the stack is empty.
        /// </summary>
        Node<T> Head = null;

        /// <summary>
        /// Inserts an object at the end of the <see cref="CustomQueue{T}"/>.
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data); // Creates a new object of Node class.

            if (Head == null) // Checks if the Head is pointing to null.
                Head = node;
            else
            {
                Node<T> temp = this.Head; // Makes the temp to point to the first element in the Queue.

                while (temp.Next != null) // Loops untill temp points to the last element in the Queue.
                    temp = temp.Next;

                temp.Next = node; // Appends the node to the end of the Queue.
            }

            Console.WriteLine("{0} inserted into Queue", node.Data);
        }

        public void Dequeue()
        {
            if (this.Head == null) // Checks if the Queue is empty or not.
            {
                Console.WriteLine("Dequeue Insuccessful as Queue is empty.");
                return;
            }

            Node<T> temp = this.Head;

            this.Head = temp.Next;
            temp.Next = null;

            Console.WriteLine($"{temp.Data} removed from the queue.");
        }

        /// <summary>
        /// Prints the elements of the <see cref="CustomQueue{T}"/> into the Console from first to last.
        /// </summary>
        public void Display()
        {         
            if (this.Head == null) // Checks if the Queue is empty or not.
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Node<T> temp = this.Head; // Makes the temp to point to the first element in the Queue.
            Console.WriteLine("The Elements in the Queue are:");

            while (temp != null) // Loops untill temp points to null.
            {
                Console.Write(temp.Data + " "); // Prints the data of the node pointed by the temp.
                temp = temp.Next; // Makes temp to point to the next element in the Queue.
            }
            Console.WriteLine("\n");
        }
    }
}
