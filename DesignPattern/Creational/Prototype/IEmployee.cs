// ******************************************************************************
//  <copyright file="IEmployee.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  IEmployee.cs
//  
//     Purpose:  Creating Interface
//     @author  Pranali Patil
//     @version 1.0
//     @since   3-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Creational.Prototype
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  this interface is used to print employee details
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns> returns the clone of object</returns>
        IEmployee Clone();

        /// <summary>
        /// Prints the details.
        /// </summary>
        /// <returns> returns the details of employee</returns>
        string PrintDetails();
    }
}
