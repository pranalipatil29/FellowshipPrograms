// ******************************************************************************
//  <copyright file="LinkedListUtility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  LinkedListUtility.cs
//  
//     Purpose:  this class is used to create operations for Linked list 
//     @author  Pranali Patil
//     @version 1.0
//     @since   26-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.LinkedList
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.IO; 
    using System.Reflection;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// this class is used to create generic type linked list
    /// </summary>
    /// <typeparam name="T">T parameter indicates the generic type of parameter</typeparam>
    public class LinkedListUtility<T>
    {
        /// <summary>
        /// The head is used to point the head node in linked list
        /// </summary>
        private static LinkedListUtility<T>.Node head;

        /// <summary>
        /// AddDataInLinkedList method is used to add a new node in linked list
        /// </summary>
        /// <param name="data">The Data parameter contains value tobe stored in linked list.</param>
        public void AddDataInLinkedList(T data)
        {
            // create a new node and assign new Data to that node
            LinkedListUtility<T>.Node newNode = new LinkedListUtility<T>.Node(data);

            // checks whteher the linked list is null or not 
            if (head == null)
            {
                // if the linked list is empty then assign a head node to new node
                head = newNode;
                newNode.Next = null;
            }
            else
            {
                // if linked list is not empty then points a current node to head
                LinkedListUtility<T>.Node currentNode = head;

                // traverse the linked list until it reaches the last node in linked list
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                // when current node reaches last node in linked list add the created new node at last in linked list
                currentNode.Next = newNode;
            }
        }

        /// <summary>
        /// PrintList method prints the linked list.
        /// </summary>
        public void PrintList()
        {
            // points a current node to head
            LinkedListUtility<T>.Node currentNode = head;

            // traverse the linked list until it reaches the last node in linked list
            while (currentNode != null)
            {
                // print the Data at current Node
                Console.WriteLine("Company Symbol : " + currentNode.Data);
                currentNode = currentNode.Next;
                Console.WriteLine("Number of Shares : " + currentNode.Data);
                currentNode = currentNode.Next;
                Console.WriteLine("Time of Transaction : " + currentNode.Data);
                currentNode = currentNode.Next;
                Console.WriteLine("\n ");
            }

            Console.Write("\n ");
        }

        /// <summary>
        /// AddInLinkedList method is used to Add word in linked list.
        /// </summary>
        /// <param name="words">The word variable contains the word which needs to add in linked list.</param>
        public void AddToLinkedList(T words)
        {
            // word variable is used to store elements
            string word = string.Empty;

            // check type of received parameter
            Type typeOfObject = words.GetType();
            Type typeOfAction = typeof(T);

            // converting received types of parameter inti string type parameter
            FieldInfo field = typeOfObject.GetField(typeOfAction.Name);
            field.SetValue(word, words);

            // singleWord variable contains a  words in file
            string[] singleWord = word.Split(' ');

            // for loop is used to iterate the loop until all words in singleWord array
            for (int i = 0; i < singleWord.Length; i++)
            {
                // converting string type parameter into T type
                T val = (T)Convert.ChangeType(singleWord[i], typeof(T));

                // adding words in linked list
                this.AddDataInLinkedList(val);
            }
        }

        /// <summary>
        /// SearchUserWord method Searches the user word in linked list
        /// if word is present in linked list it will delete the word from linked list
        /// if word not present in linked list it will return false value 
        /// </summary>
        /// <param name="searchWord">The search word.</param>
        /// <returns>returns true or false value</returns>
        public bool SearchUserWord(T searchWord)
        {
            // creating currentNode and previousNode for pointing linkedlist nodes
            LinkedListUtility<T>.Node currentnode = head;
            LinkedListUtility<T>.Node previusNode = head;

            // flag variable indicates whether required word is found or not
            bool flag = false;

            // first checks the user entered Data matches with head Node Data in linked list
            if (currentnode.Data.Equals(searchWord) && currentnode == head)
            {
                // if requered Data is present at head node then points the head pointer to Next node 
                head = currentnode.Next;
                flag = true;
            }

            // checks every node Data in linked list until list ends or Data found
            while (currentnode != null && currentnode.Data.Equals(searchWord) != true)
            {
                // increments currentNode and previousNode pointer
                previusNode = currentnode;
                currentnode = currentnode.Next;
            }

            // if Data is found checks that node is empty or not
            if (currentnode != null)
            {
                // if required Data found then change the Next pointer
                previusNode.Next = currentnode.Next;
                flag = true;
            }

            return flag;
        }

        /// <summary>
        /// class Node is used to create a new node in linked listY
        /// </summary>
        public class Node
        {
            /// <summary>
            /// The Data variable holds value for node
            /// </summary>
            public T Data;

            /// <summary>
            /// The Next is used to point the Next node in list
            /// </summary>
            public LinkedListUtility<T>.Node Next;

            /// <summary>
            /// Initializes a new instance of the <see cref="Node"/> class.
            /// </summary>
            /// <param name="dataForNode">The Data for node.</param>
            public Node(T dataForNode)
            {
                this.Data = dataForNode;
                this.Next = null;
            }
        }
    }
}
