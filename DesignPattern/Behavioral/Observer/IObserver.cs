// ******************************************************************************
//  <copyright file="IObserver.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  IObserver.cs
//  
//     Purpose:  creating interface of observer
//     @author  Pranali Patil
//     @version 1.0
//     @since   5-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Behavioral.Observer
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// creating interface
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates this instance.
        /// </summary>
        void Update();
    }
}
