// ******************************************************************************
//  <copyright file="CompanyAdapter.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  CompanyAdapter.cs
//  
//     Purpose:  Implementing Structural Design Pattern
//     @author  Pranali Patil
//     @version 1.0
//     @since   4-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Structural.Adapter
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contains company information
    /// </summary>
    /// <seealso cref="DesignPattern.Structural.Adapter.ProjectsAdaptee" />
    /// <seealso cref="DesignPattern.Structural.Adapter.ITarget" />
    public class CompanyAdapter : ProjectsAdaptee, ITarget
    {
        /// <summary>
        /// Gets the company information.
        /// </summary>
        /// <returns>
        /// returns the list of company information
        /// </returns>
        public List<string> GetCompanyInfo()
        {          
            Console.WriteLine("Company Name : ABC \n");

            // returning company project information
            return this.ProjectsInfo();
        }
    }
}
