// ******************************************************************************
//  <copyright file="Observer.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Observer.cs
//  
//     Purpose:  Implementing Observer Design Pattern to notify users
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
    /// this class is used to notify users
    /// </summary>
    /// <seealso cref="DesignPattern.Behavioral.Observer.IObserver" />
    public class Observer : IObserver
    {
        /// <summary>
        /// The name of user
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Observer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Observer(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Updates this notification.
        /// </summary>
        public void Update()
        {
            Console.WriteLine("Hello " + this.name + " new Article is published..!");
        }
    }
}
