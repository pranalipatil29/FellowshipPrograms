// ******************************************************************************
//  <copyright file="QueueUsingLinkedList.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  QueueUsingLinkedList.cs
//  
//     Purpose: Implementing Queue using Linked list
//     @author  Pranali Patil
//     @version 1.0
//     @since   5-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.Queue
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class is contains methods to perform operations on queue using linked list
    /// </summary>
    /// <typeparam name="T"> this indicates the type of parameter</typeparam>
    public class QueueUsingLinkedList<T>
    {     
        /// <summary>
        /// queueCounter variable is used to keep the count of elements in queue   
        /// </summary>
        public int QueueCounter = 0;

        /// <summary>
        ///  front and rear are the node of queue which is used to point the front and rear node of Queue        
        /// </summary>
        private QueueNode front = null, rear = null;

        /// <summary>
        /// this method is used to add the new node in queue.
        /// </summary>
        /// <param name="element">The element variable holds the value tobe added in new Node of queue.</param>
        public void EnQueue(T element)
        {
            // creating a new node to store new element in queue
            QueueNode newNode = new QueueNode(element);

            // check whether the queue is empty or not
            if (this.rear == null)
            {
                // if queue i empty then add the new node in queue and points the rear and front point to new node
                this.rear = newNode;
                this.front = newNode;

                // increment the queueCounter
                this.QueueCounter++;
            }
            else
            {
                // if queue is not empty then add the new node to next node of rear node and points the rear node to new node
                this.rear.Next = newNode;
                this.rear = newNode;

                // increment the queueCounter
                this.QueueCounter++;
            }
        }

        /// <summary>
        /// deQueue method is used to remove the elements from queue.
        /// </summary>
        /// <returns>this method returns the element at front pointer </returns>
        public T DeQueue()
        {
            // check whether the queue is empty of not
            if (this.front == null)
            {
                // if front points to null that means the queue is empty so return -1
                Console.WriteLine("Queue is Empty");
                return default(T);
            }
            else
            {
                // if queue is not empty then get the element in Node at front pointer
                T dequeueElement = this.front.ElementInQue;

                // points the front pointer to next element in queue
                this.front = this.front.Next;

                // check whether front becomes null or not
                if (this.front == null)
                {
                    // if front becomes null that means queue is now empty so assign rear to null
                    this.rear = null;
                }

                this.QueueCounter--;

                // return the removed element from queue
                return dequeueElement;
            }
        }

        /// <summary>
        /// QueueNode class creates a new Node in queue
        /// </summary>
        public class QueueNode
        {
            /// <summary>
            /// The elementInQue variable holds the value in Queue
            /// </summary>
            public T ElementInQue;

            /// <summary>
            /// The next node is used to indicate next node in linked list
            /// </summary>
            public QueueNode Next;

            /// <summary>
            /// Initializes a new instance of the <see cref="QueueNode"/> class.
            /// </summary>
            /// <param name="element">The element.</param>
            public QueueNode(T element)
            {
                this.ElementInQue = element;
                this.Next = null;
            }
        }
    }
}
