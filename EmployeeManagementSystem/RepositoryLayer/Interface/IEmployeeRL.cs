// ******************************************************************************
//  <copyright file="IEmployeeRL.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  IEmployeeRL.cs
//  
//     Purpose:  Creating interface for employee repository
//     @author  Pranali Patil
//     @version 1.0
//     @since  7 -12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************
namespace RepositoryLayer.Interface
{
    // Including the requried assemblies in to the program
    using CommonLayer.Model;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// creating interface for employee repository
    /// </summary>
    public interface IEmployeeRL
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employeeCL">The employee common layer.</param>
        /// <returns> returns the message indicating whether the operation is done or not</returns>
        string AddEmployee(EmployeeModel employeeCL);

        /// <summary>
        /// Updates the employee information.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns>returns the message indicating whether the operation is done or not</returns>
        string UpdateEmployeeInfo(EmployeeModel employeeModel, int employeeID);

        /// <summary>
        /// Deletes the employee information.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns>returns the message indicating whether the operation is done or not</returns>
        string DeleteEmployeeInfo(int employeeID);

        /// <summary>
        /// Displays the employee information.
        /// </summary>
        /// <returns>returns the list of employee information</returns>
        IList<EmployeeModel> DisplayEmployeeInfo();
    }
}
