// ******************************************************************************
//  <copyright file="VehicleFactory.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  VehicleFactory.cs
//  
//     Purpose:  Creating object of class at run time
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
    /// this class is used to create object at run time depending upon user choice
    /// </summary>
    public class VehicleFactory : AbstractVehicle
    {
        /// <summary>
        /// Gets the bike.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns> returns the object created at run time</returns>
        public override IFactory GetVehicle(int type)
        {
            // creating object depending upon user choice
            switch (type)
            {
                case 1:
                    // creating bike class object
                    return new Bike();
                   
                case 2:
                    // creating scooter class object
                    return new Scooter();
                   
                default:
                    throw new Exception("Wrong choice");
            }
        }
    }
}
