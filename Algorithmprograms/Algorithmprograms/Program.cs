/******************************************************************************
 *  Execution:    Program.cs
 *  
 *  Purpose:Take user choice to perform operation 
 *
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   11-11-2019
 *
 ******************************************************************************/
/// Including the requried assemblies in to the program
using System;

namespace Algorithmprograms
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// main method takes user choice to perform different operations according to user choice
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //flag variable checks whether user entered correct choice or not
            Boolean flag = false;
            while(flag==false)          //repeate the loop until user enter correct choice
            {
                //choice variable stores user entered choice to perform operation
                int choice;
                try
                {
                    do
                    {
                        //read user choice
                        Console.WriteLine("\n 1.Permutation of String \t 2.binary Search word \t 3.Sort words using Insertion Sort \n 4.Sort numbers usingBubble Sort" +
                            "\t 5.Sort words using Merge Sort \t 6.Anagram \t 7.Prime numbers \n 8.prime Numbers that are Anagram and Palindrome  \t9.Guess Number \t " +
                            "10.Task Scheduling \n 11.Modify Message \t 12.Exit\n Enter Your choice:");
                        choice = Convert.ToInt32(Console.ReadLine());

                        switch(choice)
                        {
                            case 1:
                                //if user wants to print Permutation of given String
                                PermutationOfString permutation = new PermutationOfString();
                                permutation.PrintPermuttaion();
                                flag = true;
                                break;
                            case 2:
                                //if user wants to Search word from list by using Binary search
                                BinarySearchWord binarySearchWord = new BinarySearchWord();
                                binarySearchWord.SearchWord();
                                flag = true;
                                break;
                            case 3:
                                //if user wants to perform Insertion sort
                                Insertionsort insertionsort = new Insertionsort();
                                insertionsort.PrintWordsUsingInsertionSort();
                                flag = true;
                                break;
                            case 4:
                                //if user wants to Perform Bubble sort
                                BubbleSort bubbleSort = new BubbleSort();
                                bubbleSort.Bubblesortarray();
                                flag = true;
                                break;
                            case 5:
                                //if user wants to perform Merge Sort
                                MergeSort mergeSort = new MergeSort();
                                mergeSort.MergeSortWordList();
                                flag = true;
                                break;
                            case 6:
                                //if user wants to check whether two strings are anagram or not
                                Anagram anagram = new Anagram();
                                anagram.anagramDetection();
                                flag = true;
                                break;
                            case 7:
                                //if user wants to Print Prime numbers
                                PrimeNumbers primeNumbers = new PrimeNumbers();
                                primeNumbers.PrintPrimeNumbers();
                                flag = true;
                                break;
                            case 8:
                                //if user wants to print prime Numbers that are Anagram And Palindrome
                                PrimeNumAnagramPalindrome anagramPalindrome = new PrimeNumAnagramPalindrome();
                                anagramPalindrome.PrintPrimeAnagramAndPalindromeNum();
                                flag = true;
                                break;
                            case 9:
                                //if user wants to find number by binary search
                                FindNumber findNumber = new FindNumber();
                                findNumber.GuessNumber();
                                flag = true;
                                break;
                            case 10:
                                //if user wants to find which task takes more time to complete its execution
                                flag = true;
                                break;
                            case 11:
                                //if user wants to modify message
                                ModifyMessage modify = new ModifyMessage();
                                modify.PrintModifiedMessage();
                                flag = true;
                                break;

                            case 12:
                                //if user wants to exit
                                flag = true;
                                break;
                            default:
                                Console.WriteLine("Wrong choice");
                                break;
                                
                        }
                    } while (choice != 12);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Please Enter Correct Choice");
                }
                Console.ReadKey();
            }
        }
    }
}
