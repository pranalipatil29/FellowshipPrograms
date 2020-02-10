/******************************************************************************
 *  Execution:    PermutationOfString.cs
 *  
 *  Purpose:Take user choice to perform operation 
 *
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   13-11-2019
 *
 ******************************************************************************/
/// Including the requried assemblies in to the program
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithmprograms
{
    class PermutationOfString
    {
        /// <summary>
        /// PrintPermuttaion method takes string from user and Prints the permuttaions for given string.
        /// </summary>
        public void PrintPermuttaion()
        {
            Utility utility = new Utility();
            try
            {
                int len, start = 0;
                String str;
                Console.WriteLine("Enter String : ");
                str = Convert.ToString(Console.ReadLine());
                len = str.Length;
                Console.WriteLine("Permutations of given String= \n");
                utility.CalPermutation(str,start,len);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter correct String");
            }
           
        }
    }
}
