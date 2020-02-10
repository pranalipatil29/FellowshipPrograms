// ******************************************************************************
//  <copyright file="Employee.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  MainClass.cs
//  
//     Purpose:  Implementing program to use reflection
//     @author  Pranali Patil
//     @version 1.0
//     @since   2-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Reflection
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    /// <summary>
    /// this class contains info of employee
    /// </summary>
    public class Employee
    {      
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee()
        {
            // assigning values to properties of employee class
            this.EmployeeName = "Abc";
            this.EmployeeId = 1;
            this.Salary = 50000;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="salary">The salary.</param>
        public Employee(string name, int id, float salary)
        {
            this.EmployeeName = name;
            this.EmployeeId = id;
            this.Salary = salary;
        }

        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        /// <value>
        /// The name of the employee.
        /// </value>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        public float Salary { get; set; }

        /// <summary>
        /// Displays the information of employee.
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine("Employee Id = " + this.EmployeeId);
            Console.WriteLine("Employee Name = " + this.EmployeeName);
            Console.WriteLine("Employee Salary = " + this.Salary);
        }
    }
}
