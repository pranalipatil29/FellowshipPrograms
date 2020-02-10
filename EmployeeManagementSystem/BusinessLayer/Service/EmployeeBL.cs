// ******************************************************************************
//  <copyright file="EmployeeBL.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  EmployeeBL.cs
//  
//     Purpose: implementing interface of business layer
//     @author  Pranali Patil
//     @version 1.0
//     @since  7 -12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************

namespace BusinessLayer.Service
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.ComponentModel.DataAnnotations;
    using BusinessLayer.Interface;
    using RepositoryLayer.Interface;
    using CommonLayer.Model;
    using CommonLayer.Constant;

    /// <summary>
    /// this class is used to validate data and implementing interface
    /// </summary>
    /// <seealso cref="BusinessLayer.Interface.IEmployeeBL" />
    public class EmployeeBL : IEmployeeBL
    {
        /// <summary>
        /// The employee repository reference
        /// </summary>
        private IEmployeeRL employeeRL;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBL"/> class.
        /// </summary>
        /// <param name="employeeRl">The employee repository reference.</param>
        public EmployeeBL(IEmployeeRL employeeRl)
        {
            this.employeeRL = employeeRl;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns>
        /// returns the message
        /// </returns>
        public string AddEmployee(EmployeeModel employeeModel)
        {
            // check whether any data entered by user is valid or not
            if(IsPropertiesAreNull(employeeModel)) 
            {
                    return ErrorMessages.Invalid;                                 
            }
            else
            {
                return employeeRL.AddEmployee(employeeModel);
            }
        }

        /// <summary>
        /// Deletes the employee information.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns> returns the message</returns>
        public string DeleteEmployeeInfo(int employeeID)
        {
            // check user entered id is valid or not
            if (employeeID != 0)
            {
               return employeeRL.DeleteEmployeeInfo(employeeID);
            }
            else
            {
                return ErrorMessages.Invalid;
            }            
        }

        /// <summary>
        /// Updates the employee information.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns> returns the message</returns>
        public string UpdateEmployeeInfo(EmployeeModel employeeModel, int employeeId)
        {
            // check user entered id is valid or not
            if (employeeId != 0) 
            {
                return employeeRL.UpdateEmployeeInfo(employeeModel, employeeId);
            }
            else
            {
                return ErrorMessages.Invalid;
            }          
        }

        /// <summary>
        /// Displays the employee information.
        /// </summary>
        /// <returns>
        /// returns the list of employee
        /// </returns>
        public IList<EmployeeModel> DisplayEmployeeInfo()
        {
           return this.employeeRL.DisplayEmployeeInfo();
        }

        /// <summary>
        /// Determines whether [is properties are null] [the specified employee model].
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns>
        ///   <c>true</c> if [is properties are null] [the specified employee model]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPropertiesAreNull(EmployeeModel employeeModel)
        {
            // iterates the loop for every element of employee
            foreach(var property in employeeModel.GetType().GetProperties())
            {
                // checking type of element 
                if(property.PropertyType == typeof(string))
                {
                    // geting value of element
                    string value = (string)property.GetValue(employeeModel);

                    // check whether element is null or empty
                    if (string.IsNullOrEmpty(value))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}