/******************************************************************************
 *  Execution:    PrimeNumAnagramPalindrome.cs
 *  
 *  Purpose:Take user choice to perform operation 
 *
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   11-11-2019
 *
 ******************************************************************************/
/// Including the requried assemblies in to the program
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithmprograms
{
    class PrimeNumAnagramPalindrome
    {
        /// <summary>
        ///PrintPrimeAnagramAndPalindromeNum method Prints the prime number which are anagram and palindrome.
        /// </summary>
        public void PrintPrimeAnagramAndPalindromeNum()
        {
            Utility utility = new Utility();
            //Print Prime Numbers Between 0-1000
            int[] primeArray=utility.CalPrimeNumbers(1000);
            Console.Write("Prime Numbers are:\n");
            for (int i = 0; i < primeArray.Length; i++)
            {
                Console.Write(primeArray[i] + ",");
            }
            //print Prime Numbers that are Palindrome
           String Palindrome= Convert.ToString(utility.CheckPalindromeNum(primeArray));
           Console.WriteLine("\n Prime numbers that are Palindrome: "+Palindrome);
            //Print Prime Numbers that are Anagram
            Console.WriteLine("\n prime Numbers that are Anagram:\n");
            utility.PrintAnagramPrimeNum(primeArray);
            Console.WriteLine("\n");
        }
    }
}
