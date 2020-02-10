// ******************************************************************************
//  <copyright file="MainAction.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  MainAction.cs
//  
//     Purpose:  Generate notification depending upon time
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
    ///  Defines the entry point of the Property Injection.
    /// </summary>
    public class MainAction
    {
        /// <summary>
        /// This method is used to generate the notification.
        /// </summary>
        public void GenerateNotification()
        {
            // creating message class incentance in which the property injection in implemented
            Message getMessage = new Message();

            // creating Notification Action class instance which implements the interface method
            NotificationAction notificationAction = new NotificationAction();

            // get current time
            int time = DateTime.Now.Hour;

            // passing instance of notificationAction class instance and current time to interface method through Message class instance
            getMessage.Notification(notificationAction, time);
        }
    }
}
