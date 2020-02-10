/******************************************************************************
  *  Execution:    DecimalToBinary.cs
 *  
 *  Purpose: Convert Decimal number into Binary
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
    class DecimalToBinary
    {
        /// <summary>
        /// PrintBinary method takes the decimal number from user convert it into binary and print binary nuber
        /// </summary>
        public void PrintBinary()
        {
            Utility utility = new Utility();
            try
            {
                //no variable stores Decimal number 
                int no;
                Console.WriteLine("Enter number: ");
                no = Convert.ToInt32(Console.ReadLine());
                int[] arr=utility.ConvertToBinary(no);
                Console.Write(" Binary representation of " + no + " is= ");
                for(int i=0;i<arr.Length;i++)
                {
                    Console.Write(arr[i]);
                }
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter correct decimal number");
            }
        }
    }
}
