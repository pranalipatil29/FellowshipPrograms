// ******************************************************************************
//  <copyright file="CreationalMenucs.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  CreationalMenucs.cs
//  
//     Purpose:  Perform operation depending upon user choice
//     @author  Pranali Patil
//     @version 1.0
//     @since   3-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Creational
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  Defines entry point in Creational Design Pattern Programs
    /// </summary>
    public class CreationalMenucs
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
                    Console.Write("\n\n 1.Singleton Pattern \n 2.Factory Design Pattern \n 3.Prototype Design Pattern \n4.Exit \n\n Enter your choice:");
                    choice = Convert.ToInt32(Console.ReadLine());

                    // perform operations depending upon user choice
                    switch (choice)
                    {
                        case 1:
                            Singleton.SingletonMain singleton = new Singleton.SingletonMain();
                            singleton.SingletonMethods();

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;

                        case 2:
                            Factory.MainFactory factory = new Factory.MainFactory();
                            factory.GetIntoFactory();

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;

                        case 3:
                            Creational.Prototype.PrototypeMain prototype = new Prototype.PrototypeMain();
                            prototype.PrintEmployeeDetails();
                           
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
        }
    }
}
