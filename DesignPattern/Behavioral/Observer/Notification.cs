// ******************************************************************************
//  <copyright file="Notification.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Notification.cs
//  
//     Purpose:  Generating notification
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
    /// this class contains methods for generating notifications
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Creates the notification.
        /// </summary>
        public void CreateNotification()
        {
            // creating object of observer operations
            ObserverOperations observerOperations = new ObserverOperations();
            
            // adding users to observer
            var observerA = new Observer("ABC");
            var observerB = new Observer("PQR");

            // adding users to observer list
            observerOperations.RegisterObserver(observerA);
            observerOperations.RegisterObserver(observerB);

            // updating article count
            observerOperations.Articles++;

            observerOperations.UnregisterObserver(observerB);
            observerOperations.Articles++;
        }
    }
}
