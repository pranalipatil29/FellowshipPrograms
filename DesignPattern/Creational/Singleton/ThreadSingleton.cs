// ******************************************************************************
//  <copyright file="ThreadSingleton.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  ThreadSingleton.cs
//  
//     Purpose:  Implementing Thread-Safe Singleton Pattern
//     @author  Pranali Patil
//     @version 1.0
//     @since   3-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Creational.Singleton
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class is used to create Thread safe Singleton design pattern
    /// </summary>
    public sealed class ThreadSingleton
    {
        /// <summary>
        /// creating object to use it for performing lock on part of code
        /// </summary>
        private static readonly object LockeObj = new object();

        /// <summary>
        ///  creating instance of ThreadSingleton class
        /// </summary>
        private static ThreadSingleton singleton = null;
       
        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSingleton"/> class from being created.
        /// </summary>
        private ThreadSingleton()
        {           
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        /// <returns> it returns the instance of class </returns>
        public static ThreadSingleton GetSingleton()
        {
            // puting lock on code 
            lock (LockeObj)
            {
                // checking whether the object of class is already created or not
                if (singleton == null)
                {
                    // if not then create the object of class
                    singleton = new ThreadSingleton();
                }
            }

            // returnig the object
            return singleton;
        }

        /// <summary>
        /// Students the information.
        /// </summary>
        public void StudentInfo()
        {
            Console.WriteLine("Student Info");
        }

        /// <summary>
        /// Teachers the information.
        /// </summary>
        public void TeacherInfo()
        {
            Console.WriteLine("Teacher Info");
        }
    }
}
