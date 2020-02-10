// ******************************************************************************
//  <copyright file="BehavioralMenu.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  BehavioralMenu.cs
//  
//     Purpose:  Implementing Behavioral Design Pattern
//     @author  Pranali Patil
//     @version 1.0
//     @since   5-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Behavioral
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Defines the entry point in Behavioral design pattern
    /// </summary>
    public class BehavioralMenu
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
                    Console.Write("\n\n 1.Observer \n 2.Visitor \n 3.Exit \n\n Enter your choice:");
                    choice = Convert.ToInt32(Console.ReadLine());

                    // perform operations depending upon user choice
                    switch (choice)
                    {
                        case 1:
                            Observer.Notification notification = new Observer.Notification();
                            notification.CreateNotification();

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;

                        case 2:
                            Visitor.VisitorMain visitorMain = new Visitor.VisitorMain();
                            visitorMain.StartVisiting();

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;

                        case 3:
                            
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
