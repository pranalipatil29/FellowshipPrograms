// ******************************************************************************
//  <copyright file="OrderedIntegerElementList.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  OrderedIntegerElementList.cs
//  
//     Purpose:  Reads List of numbers from file arrange them in accending oreder in Linked List
//               Take user input for a number and search that number in linked list
//               if number found in list then remove that number from list
//               if not then add that number at appropriate position in list and write final list into file
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
    using System.Text;

    /// <summary>
    /// OrderedIntegerElementList class contains methods to read or right numbers into file
    /// </summary>
    public class OrderedIntegerElementList
    {
        /// <summary>
        /// this method is used to Write the Integer numbers into file.
        /// </summary>
        public void WriteIntegerstoFile()
        {           
            // creating Utilityordered class object to access methods from that class
            Utilityordered utilityOrdered = new Utilityordered();
            try
            {
                // reading numbers from file and store them in NumbersFromFile variable
                string numbersFromFile = utilityOrdered.ReadIntegerElementsFromFile();

                // adding numbers into linked list 
                utilityOrdered.AddToLinkedList(numbersFromFile);

                // SortLinkedList method Sort the linked list elements 
                utilityOrdered.SortLinkedList();

                // reading number from user to search that number in linked list
                Console.WriteLine("Enter number you want to search : ");
                int searchElement = Convert.ToInt32(Console.ReadLine());

                // result variable stores the value returned by SearchUserElement method
                bool result = utilityOrdered.SearchUserElement(searchElement);

                // if result variable indicates true that means given number is found in linked list
                if (result)
                {
                    Console.WriteLine("Found And deleted From Linked List");
                }                   
                else
                {
                    // if given number is not found in linked list then add that number 
                    // in linked list at appropriate position in linked list
                    Console.WriteLine("Not found thats why added to linked list");
                    utilityOrdered.AddToLinkedListToCorrectPosition(searchElement);
                }

                // writing the linked list elements in file
                utilityOrdered.WriteToFile();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
