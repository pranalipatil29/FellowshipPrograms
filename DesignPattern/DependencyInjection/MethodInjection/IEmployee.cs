﻿// ******************************************************************************
//  <copyright file="IEmployee.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  IEmployee.cs
//  
//     Purpose:  Creating Interface
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
    /// creating interface
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Declaring method
        /// </summary>
        void DisplayEmployeeData();
    }
}
