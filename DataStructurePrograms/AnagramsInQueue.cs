// ******************************************************************************
//  <copyright file="AnagramsInQueue.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  AnagramsInQueue.cs
//  
//     Purpose:    AnagramsInQueue class is implemented to Add the Prime Numbers 
//                 that are Anagram in the Range of 0 - 1000 in a Queue using the Linked List
//                 and Print the Anagrams from the Queue.
//
//     @author  Pranali Patil
//     @version 1.0
//     @since   20-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DataStructurePrograms
{   
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// AnagramsInQueue class contains methods to print elements from Queue
    /// </summary>
    /// Including the requried assemblies in to the program
    public class AnagramsInQueue
    {
        /// <summary>
        /// PrintAnagramsFromQueue method is used to print the prime numbers which are Anagrams from queue.
        /// </summary>
        public void PrintAnagramsFromQueue()
        {
            // creating Utility class object to access methods from utility class
            Utility utility = new Utility();

            // primeNumbers array variable stores prime numbers between 0-1000 
            // GetPrimeNumbers method return prime numbers between 0-1000
            int[] primeNumbers = utility.GetPrimeNumbers(1000);

            // anagramNumber array holds all the prime numbers which are anagram
            // isAnagram method checks the prime number which are anagram and return the array contains all the anagram numbers
            int[] anagramNumbers = utility.IsAnagram(primeNumbers);

            // creating object of queueUsingLinkedList class for performing operations on queue 
            Queue.QueueUsingLinkedList queueUsingLinkedList = new Queue.QueueUsingLinkedList();

            // iterate the for loop till it reach last prime number which is anagram in anagramNumbers array
            for (int i = 0; i < anagramNumbers.Length; i++)
            {
                // enQueue method is used to store prime numbers which are anagrams in queue
                queueUsingLinkedList.EnQueue(anagramNumbers[i]);
            }

            Console.WriteLine("\nAnagrams in Queue using Linked List are as follows:\n");

            // iterate the for loop till it removes all the anagram numbers from queue
            for (int i = 0; i < queueUsingLinkedList.queueCounter; i++)
            {
                // deQueue method return the first added element in queue
                Console.Write(queueUsingLinkedList.DeQueue() + " ");
            }

            Console.WriteLine("\n");
        }
    }
}
