// ******************************************************************************
//  <copyright file="ISchool.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  ISchool.cs
//  
//     Purpose:  creating interface
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
    /// creating the interface
    /// </summary>
    public interface ISchool
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        void Accept(IVisitor visitor);
    }
}
