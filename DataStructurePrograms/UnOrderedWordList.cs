// ******************************************************************************
//  <copyright file="UnOrderedWordList.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  UnOrderedWordList.cs
//  
//     Purpose:  Reads Words from file and store them in Linked List 
//               Take word from user and search that word in linked list
//               if word found in list then remove that word from list
//               if not then add that word in list and write final list into file
//     @author  Pranali Patil
//     @version 1.0
//     @since   14-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DataStructurePrograms
{
    /// Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// UnOrderedWordList class  contains a method which perform the operation on linked list
    /// and writes the words in list into the file
    /// </summary>
    public class UnOrderedWordList
    {
        /// <summary>
        /// Write to File method  reads the words from file and store them in linked list 
        /// then takes the word from user to search it in list
        /// if given word is found in list then remove it from list else add it into list
        /// and write the list elements into file
        /// </summary>
        public void WritetoFile()
        {
            // creating object of utility class to aceess methods from utility class
            Utility utility = new Utility();
            try
            {
                // read elements from file and store that word in word variable
                string word = utility.ReadElementsFromFile();
               
                // adding words from file in linked list
                utility.AddToLinkedList(word);
                
                // reading user input to search the word from list
                Console.WriteLine("Enter String you want to search : ");
                string searchWord = Convert.ToString(Console.ReadLine());

                // checks whether the user enter space or not
                if (searchWord.Equals(" "))
                {
                    // if user enter space then give message to user that space are not accepted
                    Console.WriteLine("Please enter correct string ..null values are not accepted..!");
                }
                else
                {
                    // searching user entered word in linked list if word
                    // is found the method returrns true eles returns false
                    bool result = utility.SearchUserWord(searchWord);
                    
                    // if SearchUserWord method returns true value then we delete the word from linked list
                    if (result)
                    {
                        Console.WriteLine("Found And deleted From Linked List");
                    }                     
                    else
                    {
                        // else we add the user entered word in linked list
                        Console.WriteLine("Not found thats why added to linked list");
                        utility.AddToLinkedList(searchWord);
                    }

                    // writing linked list elements into file
                    utility.WriteToFile();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
