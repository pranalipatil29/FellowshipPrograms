// ******************************************************************************
//  <copyright file="PrototypeMain.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  PrototypeMain.cs
//  
//     Purpose:  Implementing Prototype Design Pattern
//     @author  Pranali Patil
//     @version 1.0
//     @since   3-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Creational.Prototype
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  this class contains method which is implemented by using prototype design pattern
    /// </summary>
    public class PrototypeMain
    {
        /// <summary>
        /// Prints the employee details.
        /// </summary>
        public void PrintEmployeeDetails()
        {
            Employee employee = new Employee();
            employee.EmployeeName = "Bob";
            employee.EmployeeID = 1;

            // creating copy of employee object
            Employee employeeCopy = (Employee)employee.Clone();
            employeeCopy.EmployeeName = "Alice";
            employeeCopy.EmployeeID = 2;

            Console.WriteLine(employee.PrintDetails());
            Console.WriteLine("\n" + employeeCopy.PrintDetails());           
        }
    }
}
