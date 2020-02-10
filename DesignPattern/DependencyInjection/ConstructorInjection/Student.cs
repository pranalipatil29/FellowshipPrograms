// ******************************************************************************
//  <copyright file="Student.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Student.cs
//  
//     Purpose:  Print student details
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
    /// this class implements the interface
    /// </summary>
    /// <seealso cref="DesignPattern.DependencyInjection.ConstructorInjection.IStudentData" />
    public class Student : IStudentData
    {
        /// <summary>
        /// implements the interface method to print student names
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Student Names \n Alice \n Bob");
        }
    }
}
