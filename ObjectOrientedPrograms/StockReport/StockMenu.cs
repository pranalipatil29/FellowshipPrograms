// ******************************************************************************
//  <copyright file="StockMenu.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  StockMenu.cs
//  
//     Purpose:  Performs Operations depending upon user choice to into Stock Report.
//     @author  Pranali Patil
//     @version 1.0
//     @since   25-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.StockReport
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class calls the methods depending upon user choice to generate stock report
    /// </summary>
    public class StockMenu
    {
        /// <summary>
        /// this method is used to generates the stock report.
        /// </summary>
        public void GenerateStockReport()
        {
            // choice variable is used to store user choice to perform operation
            int choice;

            // flag is used to indicate whether user entered correct choice or not
            bool flag = false;
            Console.WriteLine("\n------------Stock Account-----------\n");

            // loop iterates untill user enter correct choice
            while (flag == false)
            {
                try
                {
                    // perform operations till user wants to exit
                    do
                    {
                        // takes choice from user
                        Console.WriteLine("\n 1.Add Stock \n 2.display Stock report \n 3.Exit\n\n Enter your choice:");
                        choice = Convert.ToInt32(Console.ReadLine());

                        // creating StockUtility class object to access methods from that class
                        StockUtility stockUtility = new StockUtility();

                        // perform operations depending upon user choice
                        switch (choice)
                        {
                            case 1:
                                // if user wants to add new stock information in file
                                stockUtility.GetPersonInfo();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 2:
                                // if user wants to display stock report
                                stockUtility.DisplayStockEntry();
                                
                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 3:
                                // if user wants to exit
                                
                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            
                            default:
                                Console.WriteLine("Wrong Choice");
                                break;
                        }
                    }
                    while (choice != 3);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
