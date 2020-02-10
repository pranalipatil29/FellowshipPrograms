// ******************************************************************************
//  <copyright file="NotificationAction.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  NotificationAction.cs
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
    /// this class is used to implement INotification interface
    /// </summary>
    /// <seealso cref="DesignPattern.DependencyInjection.PropertyInjection.INotification" />
    public class NotificationAction : INotification
    {
        /// <summary>
        /// Implementing interface method
        /// </summary>
        /// <param name="time"> The time parameter is used to hold the time value.</param>
        public void ActNotification(int time)
        {            
            if (time < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time >= 12 && time < 4)
            {
                Console.WriteLine("Good afternoon");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }
        }
    }
}
