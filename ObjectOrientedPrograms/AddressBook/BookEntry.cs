// ******************************************************************************
//  <copyright file="BookEntry.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  BookEntry.cs
//  
//     Purpose:  Performs Operations depending upon user choice to into Address Book.
//     @author  Pranali Patil
//     @version 1.0
//     @since   22-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.AddressBook
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BookEntry class is used to perform operations in address book depending upon user choice
    /// </summary>
    public class BookEntry
    {
        /// <summary>
        /// GetUserEntry method is used to take user choice to add,delete or update user entry in address book.
        /// </summary>
        public void GetUserEntry()
        {
            // choice variable is used to store user choice to perform operation
            int choice;

            // flag is used to indicate whether user entered correct choice or not
            bool flag = false;
            Console.WriteLine("\n------------Address Book-----------\n");

            // loop iterates untill user enter correct choice
            while (flag == false)
            {
                try
                {
                    // perform operations till user wants to exit
                    do
                    {
                        // takes choice from user
                        Console.WriteLine("\n 1.Add \n 2.Update \n 3.Delete \n 4.Display \n 7.Exit\n\n Enter your choice:");
                        choice = Convert.ToInt32(Console.ReadLine());

                        // creating AddressBookUtility class object to access methods from that class
                        AddressBookUtility addressBookUtility = new AddressBookUtility();

                        // perform operations depending upon user choice
                        switch (choice)
                        {
                            case 1:
                                // if user wants to add new entry in address book
                                addressBookUtility.GetPersonInfo();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 2:
                                // if user wants to update data in address book
                               addressBookUtility.UpdateEntry();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 3:
                                // if user wants to delete any record from address book
                               addressBookUtility.Remove();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 4:
                                // if user wants to display all info from address book
                                addressBookUtility.DisplayAddressBookEntries();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 5:
                                // if user wants to sort entries from address book by zipcode
                               // Console.WriteLine(addressBookUtility.SortByZip());
                                
                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 6:
                                // if user wants to display all info from address book
                               // addressBookUtility.DisplayAddressBookEntries();

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