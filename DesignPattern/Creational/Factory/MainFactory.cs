// ******************************************************************************
//  <copyright file="MainFactory.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  MainFactory.cs
//  
//     Purpose:  Implementing Factory design pattern
//     @author  Pranali Patil
//     @version 1.0
//     @since   3-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Creational.Factory
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  this class is used to implement the factory design pattern
    /// </summary>
    public class MainFactory
    {
        /// <summary>
        /// Gets the into factory.
        /// </summary>
        public void GetIntoFactory()
        {
            // creating object of CheckTypeOfFactory class 
            VehicleFactory typeOfFactory = new VehicleFactory();

            // reading user choice
            Console.WriteLine("\n 1.Bike \t 2.Scooter \n Enter your choice:");
                      
            // creating object depending upon user entered choice
            IFactory objectOfFactory = typeOfFactory.GetVehicle(Convert.ToInt32(Console.ReadLine()));
            objectOfFactory.Drive(10);
        }
    }
}
