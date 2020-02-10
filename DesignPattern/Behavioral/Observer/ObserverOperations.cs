// ******************************************************************************
//  <copyright file="ObserverOperations.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  ObserverOperations.cs
//  
//     Purpose:  Implementing Observer operation
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
    /// this class is used to contain private collection of observer
    /// </summary>
    /// <seealso cref="DesignPattern.Behavioral.Observer.ISubject" />
    public class ObserverOperations : IObserverOperations
    {
        /// <summary>
        /// The list of observers 
        /// </summary>
        private List<Observer> observers = new List<Observer>();

        /// <summary>
        /// The articles count
        /// </summary>
        private int articlesCount = 1;

        /// <summary>
        /// Gets or sets the articles.
        /// </summary>
        /// <value>
        /// The articles.
        /// </value>
        public int Articles
        {
            get
            {
                return this.articlesCount;
            }

            set
            {
                // check whether new article is published or not
                if (value > this.articlesCount)
                {
                    this.articlesCount++;
                    Console.WriteLine("Notification generated");

                    // if yes then generate notification
                    this.NotifyObservers();
                }
            }
        }

        /// <summary>
        /// Registers the observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void RegisterObserver(Observer observer)
        {
            // add new observer in list
            this.observers.Add(observer);
        }

        /// <summary>
        /// Unregisters the observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void UnregisterObserver(Observer observer)
        {
            // remove observer from list
            this.observers.Remove(observer);
        }

        /// <summary>
        /// Notifies the observers.
        /// </summary>
        public void NotifyObservers()
        {
            // iterates the loop for all observer
            foreach (var observer in this.observers)
            {
                // generate notification for user in list
                observer.Update();
            }
        }
    }
}
