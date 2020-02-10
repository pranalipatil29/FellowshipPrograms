/******************************************************************************
  *  Execution:    Binary.cs
 *  
 *  Purpose: i)Swap nibbles of binary number
 *          ii)Convert new binary number to Decimal number
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
    class Binary
    {
        /// <summary>
        /// SwapBinaryNum method takes the decimal number from user convert it into binary
        /// then swap the binary number and generate the decimal number of that new binary number
        /// </summary>
        Utility utility = new Utility();
        public void SwapBinaryNum()
        {
            try
            {
                //no variable stores decimal number
                int no;
                Console.WriteLine("Enter number:");
                no = Convert.ToInt32(Console.ReadLine());
                //converting decimal to binary
                int[] binary = utility.ConvertToBinary(no);     
                Console.Write("binary no= ");
                //Print generated binary number
                foreach (int i in binary)
                {
                    Console.Write(i);
                }
                    
                //for swapping nibbles in binary number
                int[] afterSwapbinary = utility.Swapbinary(binary);  
                //Prints new Binary number after Swapping Nibbles
                Console.Write("\n After swaping binary number is= ");
                foreach(int i in afterSwapbinary)
                {
                    Console.Write(i);
                }
                //Convert new binary number into Decimal number
                int decimalnum = utility.BinarytoDecimal(afterSwapbinary);
                Console.WriteLine("\nDecimal of given binary no is= " + decimalnum);
                Console.WriteLine("\n");

            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter Correct number");
            }
        }
    }
}
