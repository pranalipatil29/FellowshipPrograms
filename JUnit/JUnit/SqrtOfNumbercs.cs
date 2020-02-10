/******************************************************************************
  *  Execution:    SqrtOfnumbercs.cs
 *  
 *  Purpose: Find sqrt of given number by using Newtons method
 *
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   09-11-2019
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;
using System.Collections.Generic;
using System.Text;

namespace JUnit
{
    class SqrtOfNumbercs
    {
        /// <summary>
        ///PrintSqrtOfNumber method takes number from user and Prints the SQRT of given number using newtoons method.
        /// </summary>
        public void PrintSqrtOfNumber()
        {
            Utility utility = new Utility();
            try
            {
                //no variable stores user entered number to find its sqrt
                int no;
                Console.WriteLine("Enter number to find its Sqrt : ");
                no = Convert.ToInt32(Console.ReadLine());
                utility.CalSqrt(no);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter correct number");
            }
        }
    }
}
