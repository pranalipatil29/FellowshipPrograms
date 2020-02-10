// ******************************************************************************
//  <copyright file="Client.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Client.cs
//  
//     Purpose:  Accessing info from company interface
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
    /// this class is used to take company information
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Gets the company information.
        /// </summary>
        public void GetCompanyInfo()
        {
            // creating interface reference to company adapter class
            ITarget adapter = new CompanyAdapter();

            // iterate the loop for all list elements 
            foreach (string info in adapter.GetCompanyInfo())
            {
                Console.WriteLine(info);
            }
        }
    }
}
