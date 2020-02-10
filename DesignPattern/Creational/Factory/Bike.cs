// ******************************************************************************
//  <copyright file="Bike.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Bike.cs
//  
//     Purpose:  Implementing Lazy Singleton design pattern
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
    ///  this class contains methods for bike
    /// </summary>
    /// <seealso cref="DesignPattern.Creational.Factory.IFactory" />
    public class Bike : IFactory
    {
        /// <summary>
        /// Drives the specified miles.
        /// </summary>
        /// <param name="miles">The miles.</param>
        public void Drive(int miles)
        {          
            Console.WriteLine("Drive the bike : " + miles + "km");
        }
    }
}
