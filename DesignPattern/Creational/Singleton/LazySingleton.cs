// ******************************************************************************
//  <copyright file="LazySingleton.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  LazySingleton.cs
//  
//     Purpose:  Implementing Lazy Singleton design pattern
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
    /// this class is used to implement lazy singleton design pattern
    /// </summary>
    public sealed class LazySingleton
    {
        /// <summary>
        /// creating lazy instance of class
        /// </summary>
        private static Lazy<LazySingleton> lazyInstance = new Lazy<LazySingleton>(() => new LazySingleton());

        /// <summary>
        /// Prevents a default instance of the <see cref="LazySingleton"/> class from being created.
        /// </summary>
        private LazySingleton()
        {
        }

        /// <summary>
        /// Gets the lazy singleton.
        /// </summary>
        /// <returns> returns the instance of class </returns>
        public static LazySingleton GetLazySingleton()
        {
            return lazyInstance.Value;
        }

        /// <summary>
        /// Companies the information.
        /// </summary>
        public void CompanyInfo()
        {
            Console.WriteLine("Company Info");
        }

        /// <summary>
        /// Employees the information.
        /// </summary>
        public void EmployeeInfo()
        {
            Console.WriteLine("Employee Info");
        }
    }
}
