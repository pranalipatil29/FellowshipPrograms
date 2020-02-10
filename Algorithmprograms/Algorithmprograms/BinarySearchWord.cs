/******************************************************************************
 *  Execution:    binarySearch.cs
 *  
 *  Purpose:    search the Word from Word List using Binary Search
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
using System.IO;
using System.Collections;
namespace Algorithmprograms
{
    class BinarySearchWord
    {
        /// <summary>
        /// SearchWord method takes word from user and Searches the word and prints the result of word found or not.
        /// </summary>
        public void SearchWord()
        {
            Utility utility = new Utility();
            try
            {
                //takes word fro user to find from list
                Console.WriteLine("Enter Word for searching: ");
                String key = Convert.ToString(Console.ReadLine());
                //reads words from file and stores them into list
                ArrayList list=utility.ReadWordsFromFile();
                //find word from list
                utility.SearchWord(list,key);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter Correct word");
            }
        }
    }
}
