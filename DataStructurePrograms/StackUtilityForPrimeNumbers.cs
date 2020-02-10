// ********************************************************************************************************************
//  <copyright file="StackUtilityForPrimeNumbers.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  StackUtilityForPrimeNumbers.cs
//  
//     Purpose:  StackUtilityForPrimeNumbers class contains methods to perform operation on stack using linked list
//     @author  Pranali Patil
//     @version 1.0
//     @since   20-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ********************************************************************************************************************/
namespace DataStructurePrograms
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StackUtilityForPrimeNumbers class contains all the methods for performing operations on stack using linked list
    /// </summary>
    public class StackUtilityForPrimeNumbers
    {
        /// <summary>
        ///  elementCounterInStack variable indicates the count of stack element
        /// </summary>
        public int elementCounterInStack = 0;

        /// <summary>
        /// The top node is used to indicating the top pointer node in stack using linked list
        /// </summary>
        public static Node top = null;

        /// <summary>
        /// PushElement method is used to push the elements in stack.
        /// </summary>
        /// <param name="element">The element variable holds the value tobe store in stack.</param>
        public void PushElement(int element)
        {
            // creating a new Node
            Node currentNode = new Node();

            // check whether the stack is overflow or not 
            if (currentNode == null)
            {
                // if stack is overflow then return 
                Console.WriteLine("Stack is OverFlow");
                return;
            }
            else
            {
                // if stack is not overflow then put the element in stack and points top node to current node
                currentNode.data = element;
                currentNode.next = top;
                top = currentNode;

                // increment the elementCounterInStack
                this.elementCounterInStack++;
            }
        }

        /// <summary>
        /// PopElement method is used to Pops the element from stack.
        /// </summary>
        /// <returns>returns the element from stack</returns>
        public int PopElement()
        {
            // check whether the stack is empty or not
            if (top == null)
            {
                // if stack is empty then return
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            else
            {
                // if stack is not empty then pop the element from stack and points the top pointer to previous node in stack
                int elementinStack = top.data;
                top = top.next;

                // return the poped element from stack
                return elementinStack;
            }
        }

        /// <summary>
        /// class Node is used to create a Node in linked list
        /// </summary>
        public class Node
        {
            /// <summary>
            /// The data variable is used to store value in node
            /// </summary>
            public int data;

            /// <summary>
            /// The next node is used to point the next node in linked list
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
    }
}