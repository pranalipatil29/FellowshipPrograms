// ******************************************************************************
//  <copyright file="Employee.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Employee.cs
//  
//     Purpose:  Implement interface methods
//     @author  Pranali Patil
//     @version 1.0
//     @since   29-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.DependencyInjection.MethodInjection
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class is used to implement the interface
    /// </summary>
    /// <seealso cref="DesignPattern.DependencyInjection.MethodInjection.IEmployee" />
    public class Employee : IEmployee
    {
        /// <summary>
        /// Displays the employee data.
        /// </summary>
        public void DisplayEmployeeData()
        {
            Console.WriteLine("Employee Names \n 1. Bob \n 2. Alice");
        }
    }
}
