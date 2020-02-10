// ******************************************************************************
//  <copyright file="InventoryManager.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  InventoryManager.cs
//  
//     Purpose: takes user choice to manage Inventory Factory
//     @author  Pranali Patil
//     @version 1.0
//     @since   26-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.InventoryManager
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class is used to access methods to perform different operation in inventory
    /// </summary>
    public class InventoryManager
    {
        /// <summary>
        /// this method is used to take user choice to perform operations
        /// </summary>
        public void ManageInventory()
        {
            // choice variable is used to store user choice to perform operation
            int choice;

            // flag is used to indicate whether user entered correct choice or not
            bool flag = false;
            Console.WriteLine("\n------------Inventory Data Management-----------\n");

            // loop iterates untill user enter correct choice
            while (flag == false)
            {
                try
                {
                    // perform operations till user wants to exit
                    do
                    {
                        // takes choice from user
                        Console.WriteLine("\n 1.Display Inventory Rice Data \n 2. 1.Display Inventory Pulses Data\n 3. 1.Display Inventory Wheats Data\n 4.Exit \n\n Enter your choice:");
                        choice = Convert.ToInt32(Console.ReadLine());

                        // creating StockUtility class object to access methods from that class
                        ManagerUtility managerUtility = new ManagerUtility();

                        // perform operations depending upon user choice
                        switch (choice)
                        {
                            case 1:
                                // if user wants to add new inventory data information in file
                                managerUtility.DisplayInventoryRiceData();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 2:
                                // if user wants to add new inventory data information in file
                                managerUtility.DisplayInventoryPulsesData();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 3:
                                // if user wants to add new inventory data information in file
                                managerUtility.DisplayInventoryWheatsData();

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
