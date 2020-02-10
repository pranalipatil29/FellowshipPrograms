// ******************************************************************************
//  <copyright file="INotification.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  INotification.cs
//  
//     Purpose:  Declaring the interface
//     @author  Pranali Patil
//     @version 1.0
//     @since   29-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.DependencyInjection.PropertyInjection
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is a interface
    /// </summary>
    public interface INotification
    {
        /// <summary>
        /// Declaring method
        /// </summary>
        /// <param name="time">The time variable is used to indicate current time.</param>
        void ActNotification(int time);
    }
}
