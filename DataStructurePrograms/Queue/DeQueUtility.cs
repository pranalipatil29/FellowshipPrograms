// ******************************************************************************
// <copyright file = "DeQueUtility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  DeQueUtility.cs
//  
//     Purpose: DeQueUtility contaions all the methods to perform operations on Dequeue
//
//     @author  Pranali Patil
//     @version 1.0
//     @since   20-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>

// ******************************************************************************/

namespace DataStructurePrograms.Queue
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// DeQueueUtility class contains all the methods to perform operations on DeQueue
    /// </summary>
    public class DeQueUtility
    {   
        /// <summary>
        /// creating front and Rear node to points DeQueue Nodes at Front and rear 
        /// </summary>
        public DequeNode front, rear;

        /// <summary>
        /// isEmpty method determines whether the DeQueue is empty or not.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if DeQueue is empty; otherwise,returns <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            // if front node is empty that means the DeQueue is empty
            return this.front == null;
        }

        /// <summary>
        /// InsertAtRear method is used to insert the element in deQueue at rear.
        /// </summary>
        /// <param name="element">The element variable holds value which insertAtRear method adds in DeQueue.</param>
        public void InsertAtRear(string element)
        {
            // create new node and store element in that node
            DequeNode newNode = new DequeNode(element);

            // first check whether the deQueueis empty or not 
            if (this.IsEmpty())
            {
                // if DeQueue is empty then assign newnode to front
                this.front = newNode;
            }
            else
            {
                // if DeQueue already have some nodes then add new node next to the rear node
                this.rear.nextNode = newNode;
                newNode.previousNode = this.rear;
            }

            // points rear to newnode in DeQueue
            this.rear = newNode;
        }

        /// <summary>
        /// removeAtRear method Removes the element in deQueue from rear point.
        /// </summary>
        /// <returns>this method returns the removed element from DeQueue</returns>
        public string RemoveAtRear()
        {
            // returnelement variable is used to store the value of node which is removed from deQueue
            string returnElement = string.Empty;

            // checks whether the rear node is empty or not
            if (this.rear == null)
            {
                // if rear node is empty that means the DeQueue is empty
                Console.WriteLine("DqQueue is empty");
                return returnElement;
            }

            // checks whether the Dequeue have only one Node or not
            if (this.front.nextNode == null)
            {
                // if deQueue have only one node then get the value stored in that node
                returnElement = this.front.dequeElement;

                // make that node null
                this.front = null;
            }
            else
            {
                // otherwise thakes the value of rear node
                returnElement = this.rear.dequeElement;

                // and remove the Node pointed by rear 
                this.rear.previousNode.nextNode = null;
            }

            // points the previous node as rear node
            this.rear = this.rear.previousNode;

            // return the value of node which is removed from Dequeue
            return returnElement;
        }

        /// <summary>
        /// IsPalindrome method is used to determine whether the specified user string is palindrome or not.
        /// </summary>
        /// <param name="userString">The userString parameter holds the String sent by user.</param>
        /// <returns>
        ///   <c>true</c> if the specified user string is palindrome; otherwise, <c>false</c>.
        /// </returns>
        public bool IsPalindrome(string userString)
        {
            // reverseString variable is used to hold the reverse string of user string
            string reverseString = string.Empty;

            // for loop iterates to get all characters from Dequeue
            for (int i = 0; i < userString.Length; i++)
            {
                // get the characters from rear point in deQueue and store it in reverseString variable
                reverseString += this.RemoveAtRear();
            }

            // checks whether the user entered string is equal to the its reverse string if yes then return true otherwise return false
            if (userString.Equals(reverseString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// this class is used to create DeQue using Doubly linked list
        /// </summary>
        public class DequeNode
        {
            /// <summary>
            /// nextNode is used to indicate the next Node of current node
            /// </summary>
            public DequeNode nextNode = null;

            /// <summary>
            ///  previousNode is used to indicate the previous Node of current node 
            /// </summary>
            public DequeNode previousNode = null;

            /// <summary>
            /// deQueElement variable holds the element in DeQueue 
            /// </summary>
            public string dequeElement;

            /// <summary>
            /// Initializes a new instance of the <see cref="DequeNode"/> class.
            /// </summary>
            /// <param name="element">The element.</param>
            public DequeNode(string element)
            {
                // assigning element which needed to add in DeQueue to deQueElement
                this.dequeElement = element;
            }
        }
    }
}
