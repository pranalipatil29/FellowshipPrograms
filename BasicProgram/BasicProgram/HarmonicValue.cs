// ******************************************************************************
//  <copyright file="HarmonicValue.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  HarmonicValue.cs
//  
//     Purpose: Print the Harmonic value of given number
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
    /// this class contains method to print harmonic value
    /// </summary>
    public class HarmonicValue
    {
        /// <summary>
        /// PrintHarmonicValue method is used to take number from user and
        /// Prints the harmonic value.
        /// </summary>
        public void PrintHarmonicValue()
        {
            try
            {
                // number variable stores the no given by user to print it's Harmonic value
                Utility utility = new Utility();
                int number;
                Console.WriteLine("Enter number to calculate it's Harmonic Value: ");
                number = Convert.ToInt32(Console.ReadLine());

                // calculating harmonic value for given number
                Console.WriteLine(utility.CalHarmonicValue(number));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }            
        }
    }
}
