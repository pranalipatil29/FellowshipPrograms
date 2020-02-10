//  ******************************************************************************
//  <copyright file="AnagramsInArray.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  AnagramsInArray.cs
//  
//     Purpose:    AnagramsInArray class is implemented to store all the prime numbers
//               which are Anagrams and not Anagrams in 2D array and print them
//  
//     @author  Pranali Patil
//     @version 1.0
//     @since   20-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
//  
//  
//   ******************************************************************************/
namespace DataStructurePrograms
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// AnagramsInArray class contains methods for printing Anagram numbers
    /// </summary>
    public class AnagramsInArray
    {
        /// <summary>
        /// PrintAnagramsInArray method is used to print the anagrams in array.
        /// </summary>
        public void PrintAnagramsInArray()
        {
            // creating Utility class object to access methods from utility class
            Utility utility = new Utility();

            // primeNumbers array variable stores prime numbers between 0-1000 
            // GetPrimeNumbers method return prime numbers between 0-1000
            int[] primeNumbers = utility.GetPrimeNumbers(1000);

            // anagramNumber array holds all the prime numbers which are anagram
            // isAnagram method checks the prime number which are anagram and return the array contains all the anagram numbers
            int[] anagramNumbers = utility.IsAnagram(primeNumbers);

            // notAnagrams array holds all the prime numbers which are not anagram
            // isNotAnagram method checks the prime number which are not anagram 
            // and return the array containing all the Prime numbers that are notanagram numbers
            int[] notAnagrams = utility.IsNotAnagram(primeNumbers, anagramNumbers);

            // storing Prime numbers that are anagrams and not anagrams in 2D array
            int[][] anagramNotAnagramInTwoD = utility.AnagramsInTwoDArray(anagramNumbers, notAnagrams);

            Console.WriteLine("\nPrime Numbers that are Anagrams and not anagrams in 2D Array:\n");

            // first for loop iterates for each row in AnagramNotAnagramInTwoD array
            for (int row = 0; row < 2; row++)
            {
                // Second for loop iterates for each column of row
                for (int j = 0; j < anagramNotAnagramInTwoD[row].Length; j++)
                {
                    // printing values in 2D array
                    Console.Write(anagramNotAnagramInTwoD[row][j] + " ");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
