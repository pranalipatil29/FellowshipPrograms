/******************************************************************************
 *  Execution:    PrimeNumbers.cs
 *  
 *  Purpose:Print Prime Numbers between 0-1000
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
    class PrimeNumbers
    {
        /// <summary>
        /// PrintPrimeNumbers method Prints the prime numbers between 0 to 1000.
        /// </summary>
        public void PrintPrimeNumbers()
        {
            Utility utility = new Utility();
            
            int[] result= utility.CalPrimeNumbers(1000);
            Console.Write("Prime Numbers are:\n");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + ",");
            }
            Console.WriteLine("\n");
        }
    }
}
