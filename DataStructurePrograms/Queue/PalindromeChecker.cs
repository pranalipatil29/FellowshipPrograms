// ******************************************************************************
//  <copyright file="PalindromeChecker.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  PalindromeChecker.cs
//  
//     Purpose: Program to take input string of characters from user and check whether it is a palindrome
//
//     @author  Pranali Patil
//     @version 1.0
//     @since   20-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DataStructurePrograms.Queue
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// PalindromeChecker class contains all the methods to find given string is palindrome or not using DeQueue
    /// </summary>
    public class PalindromeChecker
    {
        /// <summary>
        /// Palindrome method reads the input string from user and checks that string is Palindrome or not.
        /// </summary>
        public void Palindrome()
        {
            // creating DeueueUtility class object to access methods of DeQueueutiltiy class
            DeQueUtility dequeUtility = new DeQueUtility();

            // reading user entered string and store it in userString variable
            Console.WriteLine("Enter String to Check Whether String is Palindrome or not: ");
            string userString = Convert.ToString(Console.ReadLine());

            // storing characters in userString in characterInString char array variable
            char[] characterInstring = userString.ToCharArray();

            // for loop is used to add the characters of characterInString array into deQueue
            for (int i = 0; i < characterInstring.Length; i++)
            {
                // passing characters to DeQueue at rear end of DeQueue
                dequeUtility.InsertAtRear(characterInstring[i].ToString());
            }

            // checks whether the string is palindrome or not and store result in flag variable
            bool flag = dequeUtility.IsPalindrome(userString);

            // if flag holds true value that means user entered string is palindrome 
            if (flag)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                // if flag indicates false that means the user entered string is not palindrome
                Console.WriteLine("String is not Palindrome");
            }
        }
    }
}
