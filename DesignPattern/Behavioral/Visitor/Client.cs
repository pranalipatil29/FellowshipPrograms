// ******************************************************************************
//  <copyright file="Client.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Client.cs
//  
//     Purpose:  Implementing Behavioral Design Pattern
//     @author  Pranali Patil
//     @version 1.0
//     @since   5-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Behavioral.Visitor
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is client class
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Accesses the data.
        /// </summary>
        /// <param name="school">The school.</param>
        /// <param name="visitor">The visitor.</param>
        public static void AccessData(List<ISchool> school, IVisitor visitor)
        {
            // iterates the loop for all objects in school
            foreach (var element in school)
            {
                element.Accept(visitor);
            }
        }
    }
}
