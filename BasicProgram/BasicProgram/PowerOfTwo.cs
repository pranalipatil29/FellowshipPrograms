// ******************************************************************************
//  <copyright file="PowerOfTwo.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  PowerOfTwo.cs
//  
//     Purpose: prints a table of the powers of 2 that are less than or equal to 2^N.
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
    /// this class contain method to calculate and print a table of the powers of 2
    /// </summary>
    public class PowerOfTwo
    {
        /// <summary>
        ///  PrintPowerOfTwo this method is used to print the
        ///  table of power of two for given number.
        /// </summary>
        public void PrintPowerOfTwo()
        {
            // creating Utility class object to access methods from that class
            Utility utility = new Utility();
            try
            {
                // number variable holds the user entered number to prints table of the power of 2 that are <=number
                int number;
                Console.WriteLine("Enter Number:");
                number = Convert.ToInt32(Console.ReadLine());
                utility.CalPowerOfTwo(number);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }            
        }       
    }
}
