// ******************************************************************************
//  <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Program.cs
//  
//     Purpose:  Performs Operations depending upon user choice.
//     @author  Pranali Patil
//     @version 1.0
//     @since   22-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms
{
    // Including the requried assemblies in to the program
    using System;

    /// <summary>
    /// Program defines the entry point of the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The args array holds arguments from console.</param>
       public static void Main(string[] args)
        {
            // choice variable is used to store user choice to perform operation
            int choice;

            // flag is used to indicate whether user entered correct choice or not
            bool flag = false;

            // loop iterates untill user enter correct choice
            while (flag == false)
            {
                try
                {
                    // perform operations till user wants to exit
                    do
                    {
                        // takes choice from user
                        Console.WriteLine("\n 1. Address Book \n 2. Stock Report \n 3. Inventory Management \n 4. Inventory Manager \n" +
                            " 5. Commercial data processing \n 6. LinkedList \n7. Company Symbols in Stack " +
                            "\n 8. Tranasction info using Queue \n 9. Deck of Cards \n 10. Exit \n\n Enter your choice:");
                        choice = Convert.ToInt32(Console.ReadLine());

                        // perform operations depending upon user choice
                        switch (choice)
                        {
                            case 1:
                                // if user wants to performs operations in address book
                                AddressBook.BookEntry bookEntry = new AddressBook.BookEntry();
                                bookEntry.GetUserEntry();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 2:
                                // if user wants to generate Stock Report
                                StockReport.StockMenu stockMenu = new StockReport.StockMenu();
                                stockMenu.GenerateStockReport();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 3:
                                // if user wants to perform operations on inventory data
                                InventoryDataManagement.InventoryDataManagementMenu inventory = new InventoryDataManagement.InventoryDataManagementMenu();
                                inventory.GetInToInventory();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 4:
                                // if user wants to enter in Inventory Manager 
                                InventoryManager.InventoryManager inventoryManager = new InventoryManager.InventoryManager();
                                inventoryManager.ManageInventory();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 5:
                                // Commercial data processing
                                CommercialDataProcessing.StockAccount stockAccount = new CommercialDataProcessing.StockAccount();
                                stockAccount.GenerateStockReport();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 6:
                                // Linked List
                                LinkedList.StockLinkedList stockLinkedList = new LinkedList.StockLinkedList();
                                stockLinkedList.CompanyShares();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 7:
                                // creating Stackoperation class object
                                Stack.StackOperation stackOperation = new Stack.StackOperation();
                                stackOperation.GetDataFromTransaction();

                                // creating StackLinkedList class object
                                Stack.StackLinkedList<string> stackLinked = new Stack.StackLinkedList<string>();
                                stackLinked.PrintDataFromStack();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 8:
                                // creating queue class object
                                Queue.QueueOperation queueOperation = new Queue.QueueOperation();
                                queueOperation.GetDataFromTransaction();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 9:
                                // creating Deck of card class object
                                DeckOfCards.DeckOfcards deckOfcards = new DeckOfCards.DeckOfcards();
                                deckOfcards.PlayCardGame();
                               
                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 10:
                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            default:
                                Console.WriteLine("Wrong Choice");
                                break;
                        }
                    }
                    while (choice != 10);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            
            Console.ReadKey();
        }
    }
}
