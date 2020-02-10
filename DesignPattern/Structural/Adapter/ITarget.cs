// ******************************************************************************
//  <copyright file="ITarget.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  ITarget.cs
//  
//     Purpose:  Creating interface
//     @author  Pranali Patil
//     @version 1.0
//     @since   4-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Structural.Adapter
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// interface creation
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// Gets the company information.
        /// </summary>
        /// <returns> returns the list of company information</returns>
        List<string> GetCompanyInfo();
    }
}
