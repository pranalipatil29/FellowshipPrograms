// ******************************************************************************
//  <copyright file="VehicleDecorator.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  VehicleDecorator.cs
//  
//     Purpose:  Implementing decorator class
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
    /// this is Decorator class
    /// </summary>
    /// <seealso cref="DesignPattern.Structural.Decorator.IVehicle" />
    public abstract class VehicleDecorator : IVehicle
    {
        /// <summary>
        /// The vehicle is reference of interface
        /// </summary>
       private IVehicle vehicle;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleDecorator"/> class.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        public VehicleDecorator(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        /// <summary>
        /// Gets the name of the vehicle.
        /// </summary>
        /// <value>
        /// The name of the vehicle.
        /// </value>
        public string VehicleName
        {
            get { return this.vehicle.VehicleName; }
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <returns>
        /// returns the price of vehicle
        /// </returns>
        public double GetPrice()
        {
            return this.vehicle.GetPrice(); 
        }

        /// <summary>
        /// Gets the discount.
        /// </summary>
        /// <returns>returns the new price</returns>
        public abstract double GetDiscount();
    }
}
