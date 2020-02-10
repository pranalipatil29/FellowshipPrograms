// ******************************************************************************
//  <copyright file="Company.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Company.cs
//  
//     Purpose:  Performs Operations depending upon user choice.
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
    /// Defines the entry point of the Method Injection.
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Displays the company data.
        /// </summary>
        public void DisplayCompanyData()
        {
            // creating Company owner class instance 
            CompanyOwner companyOwner = new CompanyOwner();

            // calling company owner class method
            companyOwner.DisplayManagerData();

            // calling company owner class method by passing Employee class instance to method
            companyOwner.GetEmployeeData(new Employee());
        }
    }
}
