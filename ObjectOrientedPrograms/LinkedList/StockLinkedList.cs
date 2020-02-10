// ******************************************************************************
//  <copyright file="StockLinkedList.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  StockLinkedList.cs
//  
//     Purpose:  Add or Remove Company Shares 
//     @author  Pranali Patil
//     @version 1.0
//     @since   27-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.LinkedList
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StockLinkedList class is used to add or remove shares from company
    /// </summary>
    public class StockLinkedList
    {
        /// <summary>
        /// CompanyShares method is used to take user choice for adding or removing shares from Companies.
        /// </summary>
        public void CompanyShares()
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
                        Console.WriteLine("\n 1.Add Company Shares \n 2.Delete Company Shares \n 3.Display Company Shares \n 4.Exit \n\n Enter your choice:");
                        choice = Convert.ToInt32(Console.ReadLine());

                        // creating LinkedListUtility class object to access methods from that class
                        LinkedListUtility<string> linkedString = new LinkedListUtility<string>();

                        // creating CompanySharesOperation class object to access methods from that class
                        CompanySharesOperation companySharesOperation = new CompanySharesOperation();

                        // perform operations depending upon user choice
                        switch (choice)
                        {
                            case 1:
                                // if user wants to Add Company Shares 
                                companySharesOperation.AddShares();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 2:
                                // if user wants to Delete Company Shares
                                companySharesOperation.DeleteShares();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 3:
                                // if user wants to Display Company Shares
                                companySharesOperation.GetDataFromCompany();
                                linkedString.PrintList();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 4:
                                // if user wants to exit

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            default:
                                Console.WriteLine("Wrong Choice");
                                break;
                        }
                    }
                    while (choice != 4);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
