// ******************************************************************************
//  <copyright file="EmployeeRegistration.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  EmployeeRegistration.cs
//  
//     Purpose:  Implementing Employee Registration form
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
    using System.Linq;
    using System.Text;

    /// <summary>
    /// this class contains method which takes employee information from user and validate it
    /// </summary>
    public class EmployeeRegistration
    {
        /// <summary>
        /// Gets the employee information and check validation.
        /// </summary>
        public void GetEmployeeInfo()
        {
            // reading employee name
            Console.WriteLine("Enter Nmae: ");
            string name = Convert.ToString(Console.ReadLine());

            // reading employee Email Id
            Console.WriteLine("Enter Email-Id: ");
            string email = Convert.ToString(Console.ReadLine());

            // reading employee age
            Console.WriteLine("Enter age: ");
            string age = Convert.ToString(Console.ReadLine());

            // reading employee contact number
            Console.WriteLine("Enter Contact Number: ");
            string contactNumber = Convert.ToString(Console.ReadLine());

            // creating Employee data class object
            EmployeeData employeeData = new EmployeeData();

            // assigning values to employee data
            employeeData.EmployeeName = name;
            employeeData.EmailId = email;
            employeeData.Age = age;
            employeeData.ContactNumber = contactNumber;

            // passing object of employee data class to validate the values 
            ValidationContext validationContext = new ValidationContext(employeeData, null, null);

            // creating ValidationResult class object to hold validation result description
            List<ValidationResult> validationResults = new List<ValidationResult>();

            // validating all objects
            bool valid = Validator.TryValidateObject(employeeData, validationContext, validationResults, true);

            Console.WriteLine("\n" + valid);

            // if valid variable indicates false value that means there is an validation error 
            if (!valid)
            {
                // repeate the for loop for every property in Validation Result which generates validation error
                foreach (ValidationResult result in validationResults)
                {
                    // printing the member and type of error for which error is generated
                    Console.WriteLine(result.MemberNames.First() + " : " + result.ErrorMessage);
                }
            }
        }
    }
}
