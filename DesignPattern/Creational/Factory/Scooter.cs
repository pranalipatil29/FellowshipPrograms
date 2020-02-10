// ******************************************************************************
//  <copyright file="Scooter.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Scooter.cs
//  
//     Purpose:  Implementing methods for Scooter
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
    /// this class is used to implements methods for scooter
    /// </summary>
    /// <seealso cref="DesignPattern.Creational.Factory.IFactory" />
    public class Scooter : IFactory
    {
        /// <summary>
        /// Drives the specified miles.
        /// </summary>
        /// <param name="miles">The miles.</param>
        public void Drive(int miles)
        {          
            Console.WriteLine("Drive the scooter : " + miles + "km");
        }
    }
}
