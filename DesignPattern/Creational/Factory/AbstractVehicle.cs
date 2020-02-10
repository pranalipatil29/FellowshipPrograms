// ******************************************************************************
//  <copyright file="AbstractVehicle.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  AbstractVehicle.cs
//  
//     Purpose:  Creating Abstract methods
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
    ///  this is abstract class
    /// </summary>
    public abstract class AbstractVehicle
    {
        /// <summary>
        /// Gets the vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns> returns the object created at run time</returns>
        public abstract IFactory GetVehicle(int vehicle);
    }
}
