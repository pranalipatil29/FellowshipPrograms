// ******************************************************************************
//  <copyright file="Teacher.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Teacher.cs
//  
//     Purpose:  Implementing Concreate element
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
    /// this is concreate element teacher in school data structure
    /// </summary>
    /// <seealso cref="DesignPattern.Behavioral.Visitor.ISchool" />
    public class Teacher : ISchool
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public void Accept(IVisitor visitor)
        {
            visitor.VisitTeacher(this);
        }

        /// <summary>
        /// Teachers the name.
        /// </summary>
        /// <returns> returns the teacher name</returns>
        public string TeacherName()
        {
            return "Teacher 1";
        }
    }
}
