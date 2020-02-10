/******************************************************************************
 *  Execution:    MergeSort.cs
 *  
 *  Purpose: Sort the list of String using Merge Sort
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
    class MergeSort
    {
        /// <summary>
        /// MergeSortWordList method Prints array elements afterperforming Merges sort.
        /// </summary>
        public void MergeSortWordList()
        {
            Utility utility = new Utility();
            try
            {
                //get string elements in array
                String[] arr = utility.getArrayElements<String>();
                Console.WriteLine("After sorting array elements are: ");
                //perform merge sort on array and print array elements
                utility.MergeSortArrayWords(arr,0,arr.Length-1);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter Correct Words");
            }
        }
    }
}
