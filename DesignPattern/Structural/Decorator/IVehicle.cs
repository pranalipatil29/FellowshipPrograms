// ******************************************************************************
//  <copyright file="IVehicle.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  IVehicle.cs
//  
//     Purpose:  creating interface for vehicle
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
    /// this is a interface for vehicle
    /// </summary>
    public interface IVehicle
    {
        /// <summary>
        /// Gets the name of the vehicle.
        /// </summary>
        /// <value>
        /// The name of the vehicle.
        /// </value>
        string VehicleName { get; }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <returns> returns the price of vehicle</returns>
        double GetPrice();
    }
}
