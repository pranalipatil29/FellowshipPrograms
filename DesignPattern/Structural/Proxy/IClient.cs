// ******************************************************************************
//  <copyright file="IClient.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  IClient.cs
//  
//     Purpose:  Creating Interface
//     @author  Pranali Patil
//     @version 1.0
//     @since   5-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Structural.Proxy
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  creating interface
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// Requests this instance.
        /// </summary>
        void Request();
    }
}
