using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{

    /// <summary>
    /// Represents a last-in-first-out(LIFO) collection of instances of the same specified type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomStack<T>
    {

        /// <summary>
        /// A node class reference pointing to the first element of the stack or null if the stack is empty.
        /// </summary>
        protected Node<T> Top;

        /// <summary>
        /// Inserts an object at the top of the <see cref="CustomStack{T}"/>.
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value); //Creates a new object of Node class.

            if (this.Top == null) //Checks if the Top is pointing to null.
                node.Next = null; //Makes the node to point to null if Top is pointing to null.
            else
                node.Next = this.Top; //Makes the node to point to the address that is in the Top.

            this.Top = node; //Assigns the address of the node object to the "Top" field.
            Console.WriteLine("{0} pushed to stack", value); //Prints a success message in the console.
        }

        /// <summary>
        /// Prints the elements of the <see cref="CustomStack{T}"/> into the Console from top to bottom.
        /// </summary>
        public void Display()
        {
            if (this.Top == null) //Checks if the stack is empty or not.
            {
                Console.WriteLine("\nStack is empty");
                return;
            }

            Node<T> temp = this.Top; //Makes the temp to point to the address that is in the Top.
            Console.WriteLine("\nThe Elements in the Stack are:");

            //Prints all the elements of the stack one by one.
            while (temp != null)
            {
                Console.WriteLine("\t" + temp.Data);
                temp = temp.Next;
            }
        }
    }
}