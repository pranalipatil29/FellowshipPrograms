// ******************************************************************************
//  <copyright file="InventoryDataManagementMenu.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  InventoryDataManagementMenu.cs
//  
//     Purpose: takes user choice for performning operation on Inventory Data Management
//     @author  Pranali Patil
//     @version 1.0
//     @since   25-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.InventoryDataManagement
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contains method to provide different choice to user to perform operation in inventory
    /// </summary>
    public class InventoryDataManagementMenu
    {
        /// <summary>
        /// this method  provides different choice to user to perform operation in inventory
        /// </summary>
        public void GetInToInventory()
        {
            // choice variable is used to store user choice to perform operation
            int choice;

            // flag is used to indicate whether user entered correct choice or not
            bool flag = false;
            Console.WriteLine("\n------------Inventory Factory-----------\n");

            // loop iterates untill user enter correct choice
            while (flag == false)
            {
                try
                {
                    // perform operations till user wants to exit
                    do
                    {
                        // takes choice from user
                        Console.WriteLine("\n 1.Add Data \n 2.Display Inventory Data \n 3.Exit \n\n Enter your choice:");
                        choice = Convert.ToInt32(Console.ReadLine());

                        // creating StockUtility class object to access methods from that class
                        InventoryDataManagementUtility inventoryUtility = new InventoryDataManagementUtility();

                        // perform operations depending upon user choice
                        switch (choice)
                        {
                            case 1:
                                // if user wants to add new inventory data information in file
                                inventoryUtility.GetChoice();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 2:
                                // if user wants to display Inventory data
                                inventoryUtility.DisplayInventoryData();

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
