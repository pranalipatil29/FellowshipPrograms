//  ******************************************************************************
//  <copyright file="Queueusinglinkedlist.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Queueusinglinkedlist.cs
//  
//     Purpose:    Implementing Queue using linked list
//  
//     @author  Pranali Patil
//     @version 1.0
//     @since   20-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// 
//   ******************************************************************************/
namespace DataStructurePrograms.CalendarQueue
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contains methods to implement queue using linked list
    /// </summary>
    /// <typeparam name="T"> it is used to indicate type of parameter </typeparam>
    public class Queueusinglinkedlist<T>
    {
        /// <summary>
        ///  front and rear are the node of queue which is used to point the front and rear node of Queue        
        /// </summary>
        private QueueNode front = null, rear = null;

        /// <summary>
        /// queueCounter variable is used to keep the count of elements in queue   
        /// </summary>
        private int queueCounter = 0;

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
                this.queueCounter++;
            }
            else
            {
                // if queue is not empty then add the new node to next node of rear node and points the rear node to new node
                this.rear.next = newNode;
                this.rear = newNode;

                // increment the queueCounter
                this.queueCounter++;
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
                T dequeueElement = this.front.elementInQue;

                // points the front pointer to next element in queue
                this.front = this.front.next;

                // check whether front becomes null or not
                if (this.front == null)
                {
                    // if front becomes null that means queue is now empty so assign rear to null
                    this.rear = null;
                }

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
            public T elementInQue;

            /// <summary>
            /// The next node is used to indicate next node in linked list
            /// </summary>
            public QueueNode next;

            /// <summary>
            /// Initializes a new instance of the <see cref="QueueNode"/> class.
            /// </summary>
            /// <param name="element">The element.</param>
            public QueueNode(T element)
            {
                this.elementInQue = element;
                this.next = null;
            }
        }
    }
}
