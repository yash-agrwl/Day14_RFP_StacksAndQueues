using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{

    /// <summary>
    /// Represents each object in a collection.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {

        /// <summary>
        /// A type-specific field that holds the value of an instance of <see cref="Node{T}"/> class.
        /// </summary>
        public T Data;
        /// <summary>
        /// A node class reference pointing to an instance of the <see cref="Node{T}"/> class.
        /// </summary>
        public Node<T> Next;

        /// <summary>
        /// Creates an instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data"></param>
        public Node(T data)
        {
            this.Data = data;
        }
    }
}
