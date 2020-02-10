// ******************************************************************************
//  <copyright file="PrimeFactors.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  PrimeFactors.cs
//  
//     Purpose: Computes the prime factorization of N using brute force.
//     @author  Pranali Patil
//     @version 1.0
//     @since   07-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace BasicProgram
{
    /// Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contains methods to find prime factors of given number
    /// </summary>
    public class PrimeFactors
    {
        /// <summary>
        /// PrintPrimeFactors method is used to Prints the prime factors of given number.
        /// </summary>
        public void PrintPrimeFactors()
        {
            // creating Utility class object to access methods from that class
            Utility utility = new Utility();

            try
            {
                // number variable is used to store the user entered number
                int number;
                Console.WriteLine("Enter Number To find it's Prime Factors: ");
                number = Convert.ToInt32(Console.ReadLine());

                // calculating prime factors
                utility.CalPrimeFactors(number);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
