// ******************************************************************************
//  <copyright file="Teacher.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Teacher.cs
//  
//     Purpose:  Implement the constructor injection
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
    /// this class contains method to print student data
    /// </summary>
    public class Teacher
    {
        /// <summary>
        ///  creating reference of interface
        /// </summary>
        private IStudentData studentReference;

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class.
        /// </summary>
        /// <param name="interfacReference">The interface reference is a instance of interface .</param>
        public Teacher(IStudentData interfacReference)
        {
            Console.WriteLine("Teacher class constructor");

            // assigning interface instance to it's reference created in this class
            this.studentReference = interfacReference;
        }

        /// <summary>
        /// Displays this student data.
        /// </summary>
        public void Display()
        {
            this.studentReference.Print();
        }
    }
}
