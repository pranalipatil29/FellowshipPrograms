// ******************************************************************************
//  <copyright file="PrimeNumbers.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  PrimeNumbers.cs
//  
//     Purpose:  Print the Prime Numbers that are in range of 0-1000 in 2D Array.
//     @author  Pranali Patil
//     @version 1.0
//     @since   16-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DataStructurePrograms
{
    /// Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// PrimeNumbers class contains methods to print the Prime Numbers
    /// </summary>
    public class PrimeNumbers
    {
        /// <summary>
        /// PrintPrimeNumbers method is used to prints the prime numbers.
        /// </summary>
        public void PrintPrimeNumbers()
        {
            // creating Utility class object to access methods from utility class
            Utility utility = new Utility();

            // primeNumbers array variable stores prime numbers between 0-1000 
            // GetPrimeNumbers method return prime numbers between 0-1000
            int[] primeNumbers = utility.GetPrimeNumbers(1000);
            Console.WriteLine("Prime Numbers betwwen 0-1000 are as follows:");

            // stores the prime numbers in 2D jagged array
            int[][] primeNumTwoDArray = utility.StorePrimNumbersInTwoDArray(primeNumbers);
           
            // column variable indicates column in each row
            int column = 0;

            // for loop indicates row of 2D jagged array
            for (int i = 0; i < 10; i++)
            {
                // while loop prints the prime numbers stored in i'th  column
                while (column < primeNumTwoDArray[i].Length)
                {
                    // prints the prime number
                    Console.Write(primeNumTwoDArray[i][column] + " ");
                   
                    // shift to the next column
                    column++;
                }

                // goes next line to print next rows values
                Console.WriteLine("\n");  
            }
        }
    }
}
