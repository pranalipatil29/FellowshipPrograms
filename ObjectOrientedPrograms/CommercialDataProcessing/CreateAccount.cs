// ******************************************************************************
//  <copyright file="CreateAccount.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  CreateAccount.cs
//  
//     Purpose:  Create new Account for customer or company
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
    /// CreateAccount class is used to Create new Account for customer or company
    /// </summary>
    public class CreateAccount
    {
        /// <summary>
        /// TakeChoice method is used to take user choice for creating new account
        /// </summary>
        public void TakeChoice()
        {
            // choice variable is used to store user choice to perform operation
            int choice;

            // flag is used to indicate whether user entered correct choice or not
            bool flag = false;

            Console.WriteLine("\n------------Creating new Account -----------\n");

            // loop iterates untill user enter correct choice
            while (flag == false)
            {
                // perform operations till user wants to exit
                do
                {
                    // takes choice from user
                    Console.WriteLine("\n 1.Create Company Account \n 2.Create Customer account \n 3.Exit\n\n Enter your choice:");
                    choice = Convert.ToInt32(Console.ReadLine());

                    // creating StockUtility class object to access methods from that class
                    StockAccountUtility stockAccountUtility = new StockAccountUtility();

                    // perform operations depending upon user choice
                    switch (choice)
                    {
                        case 1:
                            // if user wants to Create Company Account
                            stockAccountUtility.CreateCompanyAccount();

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;
                        case 2:
                            // if user wants to Create Customer account
                            stockAccountUtility.CreateCustomerAccount();

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
        }
    }
}
