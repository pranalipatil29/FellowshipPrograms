// ******************************************************************************
//  <copyright file="Vehicle.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Vehicle.cs
//  
//     Purpose:  Implementing Decorator Pattern
//     @author  Pranali Patil
//     @version 1.0
//     @since   4-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Structural.Decorator
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Defines entry point to implement Decorator design pattern
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Gets the vehicle.
        /// </summary>
        public void GetVehicle()
        {
            // creating concreate component class object
            ConcreateComponetHonda honda = new ConcreateComponetHonda();
            Console.WriteLine("Honda City Original Price= " + honda.GetPrice());

            // creating concreate decorator class object and adding new properties to concrete component class object
            ConcreateDecoratorDiscount discount = new ConcreateDecoratorDiscount(honda);
            discount.DiscountPercentage = 20;
            Console.WriteLine(" Special Discount Offers for Honda city  \n Price are : " + discount.GetDiscount()); 
        }
    }
}
