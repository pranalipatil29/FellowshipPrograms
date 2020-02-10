// ******************************************************************************
//  <copyright file="UtilityOrdered.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  UtilityOrdered.cs
//  
//     Purpose: UtilityOrdered class contains difernrt methods to perform different operations
//
//     @author  Pranali Patil
//     @version 1.0
//     @since   15-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DataStructurePrograms.OrderedList
{
    // Including the requried assemblies in to the program
    using System; 
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
   
    /// <summary>
    /// Utility Ordered class contains methods to perform operations on linked list and file
    /// </summary>
    public class Utilityordered
    {      
        /// <summary>
        /// creating head node pointer to indicate starting node of linked list   
        /// </summary>
        public static Node head;

        /// <summary>
        /// AddDataInLinkedList method is used to add the data in linked list.
        /// </summary>
        /// <param name="data">The data variable holds the value tobe added in linked list.</param>
        public void AddDataInLinkedList(int data)
        {
            // creating a new node and store value to new node
            Node newNode = new Node(data);
           
            // checks whether the linked list is empty or not
            if (head == null)
            {
                // if head is null that means the linked list is empty so points head node to new node
                head = newNode;
                newNode.next = null;
            }
            else
            {
                // otherwise add new node next of last node
                // create currentNode pointer to points the nodes in linked list starting from head node
                Node currentNode = head;
                
                // traverse till last node in linked list
                while (currentNode.next != null)
                {
                    // goes to next node
                    currentNode = currentNode.next;
                }

                // when we reach last node in linked list add the new node to next of last node
                currentNode.next = newNode;
            }
        }

        /// <summary>
        /// PrintList method is used to print all nodes data in linked list.
        /// </summary>
        public void PrintList()
        {
            // create currentNode pointer to points the nodes in linked list starting from head node
            Node currentNode = head;
            
            // traverse till last node in linked list
            while (currentNode != null)
            {
                // prints the data in current node
                Console.WriteLine(currentNode.Data);
                
                // goes to next node
                currentNode = currentNode.next;
            }
        }

        /// <summary>
        /// ReadIntegerElementsFromFile method is used to read the integer elements from file.
        /// </summary>
        /// <returns>returns all numbers from file</returns>
        public string ReadIntegerElementsFromFile()
        {
            // returnNumber variable is used to store numbers from file
            string returnNumber = string.Empty;
            
            // creating StreamReader class object to read elements from file
            using (StreamReader streamReader = new StreamReader("IntegerNumbers.txt"))
            {
                // filenumbers variable is used to store elements from file
                string filenumbers = string.Empty;
                
                // read till streamReader reach last point in file
                while ((filenumbers = streamReader.ReadLine()) != null)
                {
                    // add elements from file into filenumbers variable
                    filenumbers += " " + streamReader.ReadLine();
                    
                    // stores elements in filenumbers into returnNumber variable
                    returnNumber += " " + filenumbers;
                }
            }

            // returns the elements from file 
            return returnNumber;
        }

        /// <summary>
        /// AddToLinkedList method is used to add to elements in linked list.
        /// </summary>
        /// <param name="words">The words variable holds the element which needed tobe added in linked list .</param>
        public void AddToLinkedList(string words)
        {
            // splits the elements storing in words variable and store them in array
            string[] singleWord = words.Split(' ');
           
            // number variable is used to store number in singleWord array
            int number;
            
            // repeat the for loop for all the elements in singleWord array
            for (int i = 1; i < singleWord.Length; i++)
            {
                // converting String type to integer type element and store it in number variable
                int.TryParse(singleWord[i], out number);
                
                // add the number in linked list
                this.AddDataInLinkedList(number);
            }
        }

        /// <summary>
        /// SearchUserElement method is used to searches the user element from linked list.
        /// </summary>
        /// <param name="searchNumber">The searchNumber variable holds the user entered number tobe searched from linked list.</param>
        /// <returns>this method returns true if user entered number is found otherwise return false</returns>
        public bool SearchUserElement(int searchNumber)
        {
            // currentnode and previusNode nodes are created to point the nodes in linked list while traversing it
            Node currentnode = head;
            Node previusNode = head;
            
            // flag is used to indicate whether the number is found or not
            bool flag = false;

            // check whwther the user enetered number is present at head node or not
            if (currentnode.Data.Equals(searchNumber) && currentnode == head)
            {
                // if user entered data is found at head node then points the head to next node in linked list
                head = currentnode.next;
                flag = true;
            }

            // traverse the linked list until last node or user entered data was found
            while (currentnode != null && currentnode.Data.Equals(searchNumber) != true)
            {
                // increments the both node pointers to next node
                previusNode = currentnode;
                currentnode = currentnode.next;
            }

            // checks whether the node is null or not
            if (currentnode != null)
            {
                // if node is not null then points the previous node to next node of current node to delete the current node from linked list
                previusNode.next = currentnode.next;
                flag = true;
            }

            // return flag indicating whether given number is found or not
            return flag;
        }

        /// <summary>
        /// SortLinkedList method is used to sorts the elements in linked list.
        /// </summary>
        public void SortLinkedList()
        {
            // creating the current node and nextNode nodes to point nodes in linked list
            Node currentNode = head, nextNode = null;
           
            // templistElement variable is created to store the element in linked list
            int templistElement = 0;
            
            // traverse the linked list till last node
            while (currentNode != null)
            {
                nextNode = currentNode.next;
                
                // traverse the linked list till nextnode becomes null
                while (nextNode != null)
                {
                    // check whether the data in currentNode is greater than it's next node data 
                    if (currentNode.Data > nextNode.Data)
                    {
                        // if yes then replace the data in both nodes
                        templistElement = currentNode.Data;
                        currentNode.Data = nextNode.Data;
                        nextNode.Data = templistElement;
                    }

                    // points nextnode pointer to next node in linked list
                    nextNode = nextNode.next;
                }

                currentNode = currentNode.next;
            }
        }

        /// <summary>
        /// AddToLinkedListToCorrectPosition method is used to add the user entered data in linked list to correct position.
        /// </summary>
        /// <param name="newNumber">The newNumber variable holds user entered new data.</param>
        public void AddToLinkedListToCorrectPosition(int newNumber)
        {
            // creating the current node and nextNode nodes to point nodes in linked list
            Node currentNode = head, nextNode = null;
            Node newNode = new Node(newNumber);
           
            // traverse the linked list till last node
            while (currentNode != null)
            {
                nextNode = currentNode.next;

                // check whether the data in currentNode is less than user eneterd number
                if (currentNode.Data < newNumber)
                {
                    // if yes checks user entered data is less than next node in linked list
                    if (newNumber < nextNode.Data)
                    {
                        // if yes then add the new node between current and next node of linked list
                        currentNode.next = newNode;
                        newNode.next = nextNode;
                        break;
                    }

                    nextNode = nextNode.next;
                }

                currentNode = currentNode.next;
            }
        }

        /// <summary>
        /// WriteToFile method is used to write elements from linked list to file.
        /// </summary>
        public void WriteToFile()
        {
            // creating currentnode to point nodes in linked list
            Node currentnode = head;
            
            // creating object for FileStream to write in file
            FileStream fileStream = new FileStream("UpdatedElements.txt", FileMode.Append, FileAccess.Write);
            
            // creating object for StreamWriter to write in file
            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.WriteLine("\n Updated information is as follows: ");
                
                // write the elements in file from linked list till current node becomes null 
                while (currentnode != null)
                {
                    // write the elements in file from linked list
                    streamWriter.Write(currentnode.Data + " ");
                    
                    // goes to next node in linked list
                    currentnode = currentnode.next;
                }

                streamWriter.WriteLine("\n");
                streamWriter.Close();
            }
        }

        /// <summary>
        /// class Node is used to create a new node in linked list
        /// </summary>
        public class Node
        {
            /// <summary>
            /// The data variable is used to hold values for node      
            /// </summary>
            public int Data;

            /// <summary>
            /// The next is a node pointer  which is used to points the next node in linked list
            /// </summary>
            public Node next;

            /// <summary>
            /// Initializes a new instance of the <see cref="Node"/> class.
            /// </summary>
            /// <param name="userdata">The user data variable holds user entered data or data from file.</param>
            public Node(int userdata)
            {
                this.Data = userdata;
                this.next = null;
            }
        }
    }
}
