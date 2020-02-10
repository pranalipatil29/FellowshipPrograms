// ******************************************************************************
//  <copyright file="ConcreateComponetHonda.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  ConcreateComponetHonda.cs
//  
//     Purpose:  Implementing Concreate component to implement Decorator design pattern
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
    /// this is concreate component for honda
    /// </summary>
    /// <seealso cref="DesignPattern.Structural.Decorator.IVehicle" />
    public sealed class ConcreateComponetHonda : IVehicle
    {
        /// <summary>
        /// Gets the Vehicle Name.
        /// </summary>
        /// <value>
        /// name of vehicle.
        /// </value>
        public string VehicleName
        {
            get { return "Honda City "; }
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <returns> returns the vehicle price</returns>
        public double GetPrice()
        {
            return 70000;
        }
    }
}
