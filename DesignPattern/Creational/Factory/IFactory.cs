// ******************************************************************************
//  <copyright file="IFactory.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  IFactory.cs
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
    /// this interface contain a method
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Drives the specified miles.
        /// </summary>
        /// <param name="miles">The miles.</param>
        void Drive(int miles);
    }
}
