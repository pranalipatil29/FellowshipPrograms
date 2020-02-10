// ******************************************************************************
//  <copyright file="Message.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Message.cs
//  
//     Purpose:  To implement Property Injection
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
    /// this class contains method which inject interface as it's property
    /// </summary>
    public class Message
    {
        /// <summary>
        ///  creating reference of interface
        /// </summary>
        private INotification notify = null;

        /// <summary>
        /// Notifications the specified notification.
        /// </summary>
        /// <param name="notification">The notification parameter is used as parameter injection.</param>
        /// <param name="time">The time parameter is used to hold the time value.</param>
        public void Notification(INotification notification, int time)
        {
            // assigning injected parameter to reference of interface
            this.notify = notification;

            // calling interface method by reference of interface
            this.notify.ActNotification(time);
        }
    }
}