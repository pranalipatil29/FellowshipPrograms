/******************************************************************************
 *  Execution:    BubbleSort.cs
 *  
 *  Purpose:    Reads int values and print them in sorted ordered using bubble Sort
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
    class BubbleSort
    {
        /// <summary>
        /// Bubblesortarray method takes integer array elements and perform Bubble sort to sort the array.
        /// </summary>
        public void Bubblesortarray()
        {
            Utility utility = new Utility();
            try
            {
                //takes integer elements in array
               int[] arr= utility.getArrayElements<int>();
                //sort the Array elements and print them
                utility.bubbleSortIntArray(arr);

            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter correct elements");
            }
        }
    }
}
