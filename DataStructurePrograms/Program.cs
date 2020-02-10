// ******************************************************************************
//  <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Program.cs
//  
//     Purpose:  Performs Operations depending upon user choice.
//     @author  Pranali Patil
//     @version 1.0
//     @since   14-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DataStructurePrograms
{
    // Including the requried assemblies in to the program
    using System;

    /// <summary>
    /// Program class Defines the entry point of the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// Main method takes choice from user to perform different types of operations
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            // choice variable contains value of user choice to perform the specific operation
            int choice;

            // flag variable is used to indicate whether user entered correct choice or not
            bool flag = false;

            // while loop will run until user enter correct choice
            while (!flag)
            {
                try
                {
                    // take choice from user and perform operations until user wants to Exit
                    do
                    {
                        // take user choice to perform operations 
                        Console.Write("\n\n 1.Search Word From file \n 2.Search Number From File \n 3.Check Balanced Parentheses \n" +
                            " 4.PrimeNumbers \n  5.Anagram numbers and not Anagram numbers in Array \n 6.Prime Anagrams in Stack\n 7.Prime Numbers that are Anagrams from Queue" +
                            "\n 8.Calender of Month \n 9. Banking Cash Counter \n 10.Palindrome Checker " +
                            " \n 11.Binary Search tree\n 12.Calendar using Queue\n " +
                            "13. Calendar Using Stack \n 14.exit \n\n Enter Your Choice:");
                        choice = Convert.ToInt32(Console.ReadLine());

                        // perform operations according to user choice
                        switch (choice)
                        {
                            case 1:
                                // if user wants to read or write Strings from File
                                UnOrderedWordList unOrderedWordList = new UnOrderedWordList();
                                unOrderedWordList.WritetoFile();

                                // flag indicates that user entered correct choice
                                flag = true;
                                break;

                            case 2:
                                // if user wants to read or write integer numbers from file
                                OrderedList.OrderedIntegerElementList orderedList = new OrderedList.OrderedIntegerElementList();
                                orderedList.WriteIntegerstoFile();

                                // flag indicates that user entered correct choice
                                flag = true;
                                break;

                            case 3:
                                // if user wants to check given expression is balanced or not
                                Stack.BalancedParentheses balancedParentheses = new Stack.BalancedParentheses();
                                balancedParentheses.PrintisExpressionBalanced();

                                // flag indicates that user entered correct choice
                                flag = true;
                                break;

                            case 4:
                                // if user wants to print prime numbers
                                PrimeNumbers primeNumbers = new PrimeNumbers();
                                primeNumbers.PrintPrimeNumbers();

                                // flag indicates that user entered correct choice
                                flag = true;
                                break;

                            case 5:
                                // if user wants to print prime Numbers that are anagrams and not anagrams
                                AnagramsInArray anagramsInArray = new AnagramsInArray();
                                anagramsInArray.PrintAnagramsInArray();

                                // flag indicates that user entered correct choice
                                flag = true;
                                break;

                            case 6:
                                // if user wants to print prime numbers that are anagrams from stack
                                AnagramsInStack anagramsInStack = new AnagramsInStack();
                                anagramsInStack.PrintPrimeNumAnagramsInStack();

                                // flag indicates that user entered correct choice
                                flag = true;
                                break;

                            case 7:
                                // if user wants to print prime numbers that are anagrams from queue
                                AnagramsInQueue anagramsInQueue = new AnagramsInQueue();
                                anagramsInQueue.PrintAnagramsFromQueue();

                                // flag indicates that user entered correct choice
                                flag = true;
                                break;

                            case 8:
                                // if user wants to print calendar of moth
                                Calendar calendar = new Calendar();
                                calendar.PrintCalendar();

                                // flag indicates that user entered correct choice
                                flag = true;
                                break;

                            case 9:
                                // if user wants to withdrow or deposite money
                                Queue.BankCounter bankCounter = new Queue.BankCounter();
                                bankCounter.CashCounter();

                                // flag indicates that user entered correct choice
                                flag = true;
                                break;

                            case 10:
                                // if user wants to check String is Palindrome or not
                                Queue.PalindromeChecker palindromeChecker = new Queue.PalindromeChecker();
                                palindromeChecker.Palindrome();

                                // flag indicates that user entered correct choice
                                flag = true;
                                break;

                            case 11:
                                // if user wants to find total number of ways to create Binary tree
                                BinarySearchTree binarySearchTree = new BinarySearchTree();
                                binarySearchTree.PrintBinarySearchTree();

                                // flag indicates that user entered correct choice
                                flag = true;
                                break;

                            case 12:
                                CalendarQueue.CalendarUsingQueue calendarUsingQueue = new CalendarQueue.CalendarUsingQueue();
                                calendarUsingQueue.PrintCalendar();
                              
                                // flag indicates that user entered correct choice
                                flag = true;
                                break;

                            case 13:
                                CalendarStack.CalendarUsingStack calendarUsingStack = new CalendarStack.CalendarUsingStack();
                                calendarUsingStack.PrintCalendar();
                                flag = true;
                                break;
                            case 14:
                                // flag indicates that user entered correct choice
                                flag = true;
                                break;

                            default:
                                Console.WriteLine("Wrong Choice\n");
                                break;
                        }
                    }
                    while (choice != 14);
                }
                catch (Exception exception)
                {
                    // throw new Exception(exception.Message);
                    Console.WriteLine(exception.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
