// ******************************************************************************
//  <copyright file="IEmployeeBL.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  IEmployeeBL.cs
//  
//     Purpose:  Creating interface for business layer
//     @author  Pranali Patil
//     @version 1.0
//     @since  7 -12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/using CommonLayer.Model;

namespace BusinessLayer.Interface
{
    
    // Including the requried assemblies in to the program
    using RepositoryLayer.Interface;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CommonLayer.Model;

    /// <summary>
    /// interface for business layer
    /// </summary>
    public interface IEmployeeBL
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns> returns the message</returns>
        string AddEmployee(EmployeeModel employeeModel);

        /// <summary>
        /// Updates the employee information.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns> returns the message </returns>
        string UpdateEmployeeInfo(EmployeeModel employeeModel, int employeeID);

        /// <summary>
        /// Deletes the employee information.
        /// </summary>
        /// <param name="emplyeeId">The emplyee identifier.</param>
        /// <returns> returns the message </returns>
        string DeleteEmployeeInfo(int emplyeeId);

        /// <summary>
        /// Displays the employee information.
        /// </summary>
        /// <returns> returns the list of employee</returns>
        IList<EmployeeModel> DisplayEmployeeInfo();
    }
}
