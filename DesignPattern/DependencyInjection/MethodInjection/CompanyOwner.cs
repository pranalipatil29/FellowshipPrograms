// ******************************************************************************
//  <copyright file="CompanyOwner.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  CompanyOwner.cs
//  
//     Purpose:  Display Manager and Employee information in company
//     @author  Pranali Patil
//     @version 1.0
//     @since   29-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.DependencyInjection.MethodInjection
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contains methods to display information of manager and employee
    /// </summary>
    public class CompanyOwner
    {
        /// <summary>
        /// creating reference of the interface 
        /// </summary>
       private IEmployee employeeReference;

        /// <summary>
        /// this method is used to display employee data
        /// </summary>
        /// <param name="employee">The employee is a instance of interface which is injected in method.</param>
        public void GetEmployeeData(IEmployee employee)
        {
            // the interface instance is assign to interface reference
            this.employeeReference = employee;

            // calling interface method to print employee data
            this.employeeReference.DisplayEmployeeData();
        }

        /// <summary>
        /// Displays the manager data.
        /// </summary>
        public void DisplayManagerData()
        {
            Console.WriteLine("\nManager Name: Abc Xyz");
            Console.WriteLine("Manager Salary : 50000");
        }
    }
}
