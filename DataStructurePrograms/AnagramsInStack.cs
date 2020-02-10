// ******************************************************************************
//  <copyright file="AnagramsInStack.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  AnagramsInStack.cs
//  
//     Purpose:  AnagramsInStack class is implemented toAdd the Prime Numbers that 
//               are Anagram in the Range of 0 - 1000 in a Stack using the Linked
//               List and Print the Anagrams in the Reverse Order.
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
    /// AnagramsInStack class contains methods to print anagram numbers from stack
    /// </summary>
    /// Including the requried assemblies in to the program
    public class AnagramsInStack
    {
        /// <summary>
        /// this method is used to print the Prime Numbers which are anagrams in stack.
        /// </summary>
        public void PrintPrimeNumAnagramsInStack()
        {
            // creating Utility class object to access methods from utility class
            Utility utility = new Utility();

            // primeNumbers array variable stores prime numbers between 0-1000 
            // GetPrimeNumbers method return prime numbers between 0-1000
            int[] primeNumbers = utility.GetPrimeNumbers(1000);

            // anagramNumber array holds all the prime numbers which are anagram
            // isAnagram method checks the prime number which are anagram and return the array contains all the anagram numbers
            int[] anagramNumbers = utility.IsAnagram(primeNumbers);

            // creating object for StackUtilityForPrimeNumbers class to access methods of that class
            StackUtilityForPrimeNumbers stackUtilityForPrimeNumbers = new StackUtilityForPrimeNumbers();

            // iterate the for loop for all anagram numners in anagramNumbers array
            for (int i = 0; i < anagramNumbers.Length; i++)
            {
                stackUtilityForPrimeNumbers.PushElement(anagramNumbers[i]);
            }

            Console.WriteLine("\nPrime Numbers that are anagrams in stack using Linked List are as follows: \n");

            // iterate the for loop for all the elements in stack 
            for (int i = 0; i < stackUtilityForPrimeNumbers.elementCounterInStack; i++)
            {
                // store the element from stack into element variable
                int element = stackUtilityForPrimeNumbers.PopElement();

                // print the element 
                Console.Write(element + " ");
            }
        }
    }
}
