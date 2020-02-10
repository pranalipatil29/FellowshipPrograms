// ******************************************************************************
//  <copyright file="Employee.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Employee.cs
//  
//     Purpose:  Creating class for Printing Employee Details
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
    ///  this class is used to get or set employee details
    /// </summary>
    /// <seealso cref="DesignPattern.Creational.Prototype.IEmployee" />
    public class Employee : IEmployee
    {
        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        /// <value>
        /// The name of the employee.
        /// </value>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns> returns the clone of properties</returns>
        public IEmployee Clone()
        {
            return (IEmployee)this.MemberwiseClone();
        }

        /// <summary>
        /// Prints the details.
        /// </summary>
        /// <returns> returns the details of employee</returns>
        public string PrintDetails()
        {
            return string.Format("Employee ID: " + this.EmployeeID + "\nEmployee Name: " + this.EmployeeName);
        }
    }
}
