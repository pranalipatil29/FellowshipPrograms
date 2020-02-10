// ******************************************************************************
//  <copyright file="EmployeeModel.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  EmployeeModel.cs
//  
//     Purpose:  creating Validation for data
//     @author  Pranali Patil
//     @version 1.0
//     @since  7 -12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************
namespace CommonLayer.Model
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// this class is used to validate the data for employee
    /// </summary>
    public class EmployeeModel
    {
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        /// <value>
        /// The name of the employee.
        /// </value>
        [RegularExpression(("^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$"), ErrorMessage = "Invalid Name")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets or sets the email identifier.
        /// </summary>
        /// <value>
        /// The email of employee.
        /// </value>
        [EmailAddress]
        public string EmailID { get; set; }

        /// <summary>
        /// Gets or sets the password of employee.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required]
        public string Password{ get; set; }

        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        /// <value>
        /// The designation of employee.
        /// </value>
        [RegularExpression(("^[A-Za-z.\\s]+\\s*$"), ErrorMessage = "Invalid Designation")]
        public string Designation { get; set; }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        [Range(1000, 1000000)]
        public int Salary { get; set; }

    }
}
