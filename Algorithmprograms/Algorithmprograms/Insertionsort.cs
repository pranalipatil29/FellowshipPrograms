/******************************************************************************
 *  Execution:    InsertionSort.cs
 *  
 *  Purpose: reads the words and print them in sorted oreder using insertion sort
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
    class Insertionsort
    {
        /// <summary>
        ///PrintWordsUsingInsertionSort method takes String elements in array 
        ///Perform insertion sort on arraly and Prints sorted array.
        /// </summary>
        public void PrintWordsUsingInsertionSort()
        {
            Utility utility = new Utility();
            try
            {
                //takes string elements in array
                String[] arr = utility.getArrayElements<String>();
                Console.WriteLine("Array Elements After sorting:\n");
                //perform insertion sort on array and print it
                utility.InsertionSortArray(arr);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter correct value");
            }                 

        }
    }
}
