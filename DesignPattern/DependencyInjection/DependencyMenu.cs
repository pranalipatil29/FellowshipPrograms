// ******************************************************************************
//  <copyright file="DependencyMenu.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  DependencyMenu.cs
//  
//     Purpose:  Performs Operations depending upon user choice.
//     @author  Pranali Patil
//     @version 1.0
//     @since   29-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.DependencyInjection
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contains method which is used to perform operation according to user choice
    /// </summary>
   public class DependencyMenu
    {
        /// <summary>
        /// Dependency method is used to perform operations depending on user choice
        /// </summary>
        public void Dependency()
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
                        Console.Write("\n\n 1. Constructor Injection \n 2. Property Injection \n 3. Method Injection \n 4. Exit \n\n Enter your choice:");
                        choice = Convert.ToInt32(Console.ReadLine());

                        // perform operations depending upon user choice
                        switch (choice)
                        {
                            case 1:
                                // if user wants to perform construction injection
                                ConstructorInjection.School constructionInjection = new ConstructorInjection.School();
                                constructionInjection.Dependency();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 2:
                                // if user wants to perform Property injection
                                PropertyInjection.MainAction mainAction = new PropertyInjection.MainAction();
                                mainAction.GenerateNotification();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 3:
                                // if user wants to perform Method injection
                                MethodInjection.Company company = new MethodInjection.Company();
                                company.DisplayCompanyData();
                               
                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;
                            case 4:

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
