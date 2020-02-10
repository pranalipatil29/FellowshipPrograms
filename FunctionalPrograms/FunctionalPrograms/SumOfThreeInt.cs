/******************************************************************************
 *  Execution:    SumOfThreeInt.cs
 *  Purpose: Count the Number of triplets that sum to exactly 0.
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   07-11-2019
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    public class SumOfThreeInt
    {
        /// <summary>
        /// PrintSumOfThreeInt method is used to prints the sum of three integer 
        /// numbers from array which sum equals to zero.
        /// </summary>
        public void PrintSumOfThreeInt()
        {
            Utility utility = new Utility();
            int size;
            try
            {
                //take the size of array form user
                Console.WriteLine("Enter size of array: ");
                size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(size);
                //reads the elements in array
                int[] arr = utility.ReadIntArray(size);
                //find and print number of triplets which exactly sum 0
                utility.FindSumOfThreeInt(arr, size);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Correct number "+e);
            }



}
        
        
    }
}
