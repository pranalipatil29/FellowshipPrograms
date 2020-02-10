// ******************************************************************************
//  <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Program.cs
//  
//     Purpose:  Performs Operations depending upon user choice.
//     @author  Pranali Patil
//     @version 1.0
//     @since   29-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern
{
    // Including the requried assemblies in to the program
    using System;

    /// <summary>
    /// This class defines the entry point of the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
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
                        Console.Write("\n\n 1.Creational Design Pattern \n 2.Dependency Injection \n 3.Annotation \n 4. Reflection\n"
                            + " 5.Structural Design Pattern  \n 6.Behavioral Design Pattern \n7.Exit \n\n Enter your choice:");
                        choice = Convert.ToInt32(Console.ReadLine());

                        // perform operations depending upon user choice
                        switch (choice)
                        {
                            case 1:
                                // if user wants to perform Creational Design Pattern
                                Creational.CreationalMenucs creational = new Creational.CreationalMenucs();
                                creational.GetChoice();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 2:
                                // if user wants to perform Dependency injection
                                DependencyInjection.DependencyMenu dependencyMenu = new DependencyInjection.DependencyMenu();
                                dependencyMenu.Dependency();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 3:
                                // if user wants to perform Annotation
                                Annotation.EmployeeRegistration employeeRegistration = new Annotation.EmployeeRegistration();
                                employeeRegistration.GetEmployeeInfo();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 4:
                                // if user wants to perform Reflction
                                Reflection.MainClass employee = new Reflection.MainClass();
                                employee.GetInfoOfClass();
                                
                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 5:
                                Structural.StructuralMenu structuralMenu = new Structural.StructuralMenu();
                                structuralMenu.GetChoice();
                                
                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 6:
                                Behavioral.BehavioralMenu behavioralMenu = new Behavioral.BehavioralMenu();
                                behavioralMenu.GetChoice();

                                // make flag true to indicate user enter correct choice
                                flag = true;
                                break;

                            case 7:
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

            Console.ReadKey();
        }
    }
}
