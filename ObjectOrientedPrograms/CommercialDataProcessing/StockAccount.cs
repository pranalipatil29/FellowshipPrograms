// ******************************************************************************
//  <copyright file="StockAccount.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  StockAccount.cs
//  
//     Purpose:  Generate Stock Report
//     @author  Pranali Patil
//     @version 1.0
//     @since   26-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// GenerateStockReport method is used to generate Stock Report
    /// </summary>
    public class StockAccount
    {
        /// <summary>
        /// this method is used to generate the stock report.
        /// </summary>
        public void GenerateStockReport()
        {
            // choice variable is used to store user choice to perform operation
            int choice;

            // flag is used to indicate whether user entered correct choice or not
            bool flag = false;
            Console.WriteLine("\n------------Stock Information -----------\n");

            // loop iterates untill user enter correct choice
            while (flag == false)
            {
                try
                {
                    // perform operations till user wants to exit
                    do
                    {
                        // takes choice from user
                        Console.WriteLine("\n 1.Create Stock Account \n 2.Buy Shares \n 3.Sell Shares \n 4.Print Stock Report \n 5.Delete Company " +
                            "\n 6.Delete Customer \n 7.Exit\n\n Enter your choice:");
                        choice = Convert.ToInt32(Console.ReadLine());

                        // creating StockUtility class object to access methods from that class
                        StockAccountUtility stockAccountUtility = new StockAccountUtility();

                        // creating CreateAccount class object to access methods of that class
                        CreateAccount createAccount = new CreateAccount();

                        // perform operations depending upon user choice
                        switch (choice)
                        {
                            case 1:
                                // if user wants to Create stock account
                                createAccount.TakeChoice();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 2:
                                // if user wants to Buy Shares
                                stockAccountUtility.Buy();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 3:
                                // if user wants to Sell Shares
                                stockAccountUtility.Sell();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 4:
                                // if user wants to display stock report
                                stockAccountUtility.PrintStockReport();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 5:
                                // if user wants to delete company 
                                stockAccountUtility.DeleteCompany();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 6:
                                // if user wants to delete Customer 
                                stockAccountUtility.DeleteCustomer();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 7:
                                // if user wants to exit

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            default:
                                Console.WriteLine("Wrong Choice");
                                break;
                        }
                    }
                    while (choice != 7);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
