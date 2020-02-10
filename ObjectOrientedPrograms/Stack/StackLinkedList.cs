// ******************************************************************************
//  <copyright file="StackLinkedList.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  StackLinkedList.cs
//  
//     Purpose: Perform operations of adding and removing company symbols in stack using linked list
//     @author  Pranali Patil
//     @version 1.0
//     @since   28-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.Stack
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class is used to perform stack operation using linked list
    /// </summary>
    /// <typeparam name="T"> T is used to indicate type of parameter</typeparam>
    public class StackLinkedList<T>
    {   
        /// <summary>
        /// The top variable is used to indicate top node in linked list    
        /// </summary>
        private static StackLinkedList<T>.Node top = null;

        /// <summary>
        /// push method is used to push the specified data in stack linked lists.
        /// </summary>
        /// <param name="data">The data variable contains a data which is needed to push in stack linked list.</param>
        public void Push(T data)
        {
            // creating a new node to push new data in stack
            StackLinkedList<T>.Node currentNode = new StackLinkedList<T>.Node();

            // checks whether the stack is full or not if not then add the new node in stack
            if (currentNode == null)
            {
                Console.WriteLine("Stack is Overflow");
                return;
            }
            else
            {
                // pushing data into stck
                currentNode.Data = data;
                currentNode.Next = top;
                top = currentNode;
            }
        }

        /// <summary>
        /// Pop method Pops the data from stack
        /// </summary>
        /// <returns>returns the data from stack</returns>
        public T Pop()
        {
            // checks whether the stack is empty or not
            if (top == null)
            {
                // if stack is empty, there is nothing to return
                Console.WriteLine("Stack is empty");
                return default(T);
            }
            else
            {
                // if stack is not empty then returns the data in stack 
                T popedChar = top.Data;
                top = top.Next;

                // returning the poped character from stack
                return popedChar;
            }
        }

        /// <summary>
        /// this method is used to checks whether the stack is empty or not 
        /// </summary>
        /// <returns>
        ///   <c>returns true</c> if this instance is empty; otherwise, <c>returns false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            return top == null ? true : false;
        }

        /// <summary>
        /// this method is used to prints the data from stack.
        /// </summary>
        public void PrintDataFromStack()
        {
            while (!this.IsEmpty())
            {
                Console.WriteLine("Transaction Name : " + this.Pop());
                Console.WriteLine("Company Symbol  : " + this.Pop() + "\n");
            }
        }

        /// <summary>
        /// this class is used to create Node in linked list
        /// </summary>
        public class Node
        {
            /// <summary>
            /// The data variable is used to indicate the data value for Node 
            /// </summary>
            public T Data;

            /// <summary>
            /// The next is used to indicate next node in Linked list
            /// </summary>
            public StackLinkedList<T>.Node Next;

            /// <summary>
            /// Initializes a new instance of the <see cref="Node"/> class.
            /// </summary>
            public Node()
            {
                this.Next = null;
            }
        }
    }
}
