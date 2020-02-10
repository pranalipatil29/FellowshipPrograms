// ******************************************************************************
//  <copyright file="StackUtility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  StackUtility.cs
//  
//     Purpose:   Implement methods to perform operation on stack using linkes list
//
//     @author  Pranali Patil
//     @version 1.0
//     @since   5-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
//
// ******************************************************************************/
namespace DataStructurePrograms.CalendarStack
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// contains methods to perform operation on stack
    /// </summary>
    /// <typeparam name="T"> indicate type of parameter</typeparam>
    public class StackUtility<T>
    {
             /// <summary>
            /// Node class is used to create a new Node in linked list
            /// </summary>
            public class Node
            {
                /// <summary>
                /// The data variable is used to indicate the data value for Node 
                /// </summary>
                public T data;

                /// <summary>
                /// The next is used to indicate next node in Linked list
                /// </summary>
                public Node next;

                /// <summary>
                /// Initializes a new instance of the <see cref="Node"/> class.
                /// </summary>
                public Node()
                {
                    this.next = null;
                }
            }

            /// <summary>
            /// The top variable is used to indicate top node in linked list    
            /// </summary>
            public static Node top = null;

            /// <summary>
            /// push method is used to push the specified expression character in stack linked lists.
            /// </summary>
            /// <param name="expressionChar">The expressionChar variable contains a character which is needed to push in stack linked list.</param>
            public void Push(T expressionChar)
            {
                // creating a new node to push new character in stack
                Node currentNode = new Node();

                // checks whether the stack is full or not if not then add the new node in stack
                if (currentNode == null)
                {
                    Console.WriteLine("Stack is Overflow");
                    return;
                }
                else
                {
                    // pushing character in given expression into stck
                    currentNode.data = expressionChar;
                    currentNode.next = top;
                    top = currentNode;
                }
            }

            /// <summary>
            /// Pop method Pops the character from stack
            /// </summary>
            /// <returns>returns the character from stack</returns>
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
                    // if stack is not empty then returns the character in stack 
                    T popedChar = top.data;
                    top = top.next;

                    // returning the poped character from stack
                    return popedChar;
                }
            }

            /// <summary>
            /// isEmpty method is used to checks whether the stack is empty or not 
            /// </summary>
            /// <returns>
            ///   <c>returns true</c> if this instance is empty; otherwise, <c>returns false</c>.
            /// </returns>
            public bool IsEmpty()
            {
                return top == null ? true : false;
            }
        }
    }
