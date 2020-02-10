// ******************************************************************************
//  <copyright file="ProjectsAdaptee.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  ProjectsAdaptee.cs
//  
//     Purpose:  Creating Adaptee class for structural design pattern
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
    ///  this class contains method to store project details
    /// </summary>
    public class ProjectsAdaptee
    {
        /// <summary>
        /// this method contains projects information.
        /// </summary>
        /// <returns> returns the list of projects </returns>
        public List<string> ProjectsInfo()
        {
            List<string> projects = new List<string>();
            projects.Add("Hospital Management");
            projects.Add("PHR System");
            Console.WriteLine("Projects: ");
            return projects;
        }
    }
}
