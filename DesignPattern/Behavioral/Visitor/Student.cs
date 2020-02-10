// ******************************************************************************
//  <copyright file="Student.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Student.cs
//  
//     Purpose:  Implementing concreate element 
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
    /// this class contains methods for concreate element student
    /// </summary>
    /// <seealso cref="DesignPattern.Behavioral.Visitor.ISchool" />
    public class Student : ISchool
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public void Accept(IVisitor visitor)
        {
            visitor.VisitStudent(this);
        }

        /// <summary>
        /// this method is used to return student name.
        /// </summary>
        /// <returns> returns the student name</returns>
        public string StudentName()
        {
            return "Student 1";
        }
    }
}
