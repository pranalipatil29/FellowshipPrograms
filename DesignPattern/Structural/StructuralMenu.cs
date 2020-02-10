// ******************************************************************************
//  <copyright file="StructuralMenu.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  StructuralMenu.cs
//  
//     Purpose:  Implementing Structural Design Pattern
//     @author  Pranali Patil
//     @version 1.0
//     @since   4-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Structural
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  Defines entry point in structural Design pattern
    /// </summary>
    public class StructuralMenu
    {
        /// <summary>
        /// Gets the choice from user.
        /// </summary>
        public void GetChoice()
        {
            // choice variable is used to store user choice to perform operation
            int choice;

            // flag is used to indicate whether user entered correct choice or not
            bool flag = false;

            // loop iterates untill user enter correct choice
            while (flag == false)
            {
                // perform operations till user wants to exit
                do
                {
                    // takes choice from user
                    Console.Write("\n\n 1.Adapter \n 2.Facade \n 3.Decorator \n 4.Proxy \n 5.Exit \n\n Enter your choice:");
                    choice = Convert.ToInt32(Console.ReadLine());

                    // perform operations depending upon user choice
                    switch (choice)
                    {
                        case 1:
                            Adapter.Client client = new Adapter.Client();
                            client.GetCompanyInfo();
                            
                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;

                        case 2:
                            Facade.LibrarySystem librarySystem = new Facade.LibrarySystem();
                            librarySystem.Library();
                           
                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;

                        case 3:
                            Decorator.Vehicle vehicle = new Decorator.Vehicle();
                            vehicle.GetVehicle();
                            
                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;

                        case 4:
                            Proxy.ProxyMain proxyMain = new Proxy.ProxyMain();
                            proxyMain.GetProxyAccess();
                           
                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;

                        case 5:
                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;

                        default:
                            Console.WriteLine("Wrong Choice");
                            break;
                    }
                }
                while (choice != 5);
            }
        }
    }
}
