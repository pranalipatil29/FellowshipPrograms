/******************************************************************************
 *  Execution:    Anagram.cs
 *  
 *  Purpose: Check whether two Strings Are Anagram or not
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
    class Anagram
    {
        /// <summary>
        ///anagramDetection method takes 2 strings from user and checks whether they are Anagrams or not and print result.
        /// </summary>
        public void anagramDetection()
        {
            Utility u = new Utility();
            try
            {
                String str1, str2;
                //takes two strings from user
                Console.WriteLine("Enter two Strings to check they are anagram or not: ");
                str1 = Convert.ToString(Console.ReadLine());
                str2 = Convert.ToString(Console.ReadLine());
                //check whwther tow strings are anagram or not
                Boolean flag1 = u.CheckAnagram(str1, str2);
                //if flag1 is true that means both strings are anagram else both strings are not anagrams
                if (flag1)                                                      
                    Console.WriteLine(str1 + " and " + str2 + " are Anagram");
                else
                    Console.WriteLine(str1 + " and " + str2 + " are not Anagram");

            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter correct strings"+e);
            }
        }
    }
}
