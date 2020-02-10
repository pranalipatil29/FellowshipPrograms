// ******************************************************************************
//  <copyright file="IObserverOperations.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  IObserverOperations.cs
//  
//     Purpose:  Creating interface of observer Operations
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
    public interface IObserverOperations
    {
        /// <summary>
        /// Registers the observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        void RegisterObserver(Observer observer);

        /// <summary>
        /// Unregisters the observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        void UnregisterObserver(Observer observer);

        /// <summary>
        /// Notifies the observers.
        /// </summary>
        void NotifyObservers();
    }
}
