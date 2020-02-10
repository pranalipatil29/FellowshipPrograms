// ******************************************************************************
//  <copyright file="School.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  School.cs
//  
//     Purpose:  Print school details
//     @author  Pranali Patil
//     @version 1.0
//     @since   29-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.DependencyInjection.ConstructorInjection
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  Defines the entry point of the Constructor Injection.
    /// </summary>
    public class School
    {
        /// <summary>
        /// this method is used to call methods to print information
        /// </summary>
        public void Dependency()
        {
            // creating instance of teacher class and passing it's constructor the instance of Student class
            Teacher constructorInjection = new Teacher(new Student());
            constructorInjection.Display();
        }
    }
}
