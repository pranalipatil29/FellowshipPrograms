// ******************************************************************************
//  <copyright file="EmployeeData.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  EmployeeData.cs
//  
//     Purpose:  Creating Module for employee data
//     @author  Pranali Patil
//     @version 1.0
//     @since   2-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Annotation
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
  
    /// <summary>
    /// this class is used to get or set values for employee information
    /// </summary>
    public class EmployeeData
    {
        /// <summary>
        /// This variable is used to hold value of employee name
        /// </summary>
        private string employeeName;

        /// <summary>
        /// This variable is used to hold value of employee email id
        /// </summary>
        private string emailId;

        /// <summary>
        /// This variable is used to hold value of employee age
        /// </summary>
        private string age;

        /// <summary>
        /// This variable is used to hold value of employee contact number
        /// </summary>
        private string contactNumber;

        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        /// <value>
        /// The name of the employee.
        /// </value>
        [Required(ErrorMessage = "Name is Requird")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name should have minimum 3 & maximum 20 Characters")]
        [RegularExpression((@"^[A-Z][a-z]+$"), ErrorMessage = "Invalid Name")]
        public string EmployeeName { get => this.employeeName; set => this.employeeName = value; }

        /// <summary>
        /// Gets or sets the email identifier.
        /// </summary>
        /// <value>
        /// The email identifier.
        /// </value>
        [Required(ErrorMessage = "Valid Email Id is Required")]       
        [EmailAddress(ErrorMessage = "Invalid EmailId")]
        public string EmailId { get => this.emailId; set => this.emailId = value; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        [Required(ErrorMessage = "Age is Required")]
        [Range(18, 70, ErrorMessage = "Age should be between 18 to 70")]
        [RegularExpression((@"^[0-9]{2}$"), ErrorMessage = "Age is invalid")]
        public string Age { get => this.age; set => this.age = value; }

        /// <summary>
        /// Gets or sets the contact number.
        /// </summary>
        /// <value>
        /// The contact number.
        /// </value>
        [Required(ErrorMessage = "Contact Number is required")]   
        [Phone]
        [RegularExpression((@"[91][0-9]{9}$"), ErrorMessage = "Contact number is invalid")]
        public string ContactNumber { get => this.contactNumber; set => this.contactNumber = value; }
    }
}
