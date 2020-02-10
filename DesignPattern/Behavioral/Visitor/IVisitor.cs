// ******************************************************************************
//  <copyright file="IVisitor.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  IVisitor.cs
//  
//     Purpose: creating interface
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
    public interface IVisitor
    {
        /// <summary>
        /// Visits the student.
        /// </summary>
        /// <param name="student">The student.</param>
        void VisitStudent(Student student);

        /// <summary>
        /// Visits the teacher.
        /// </summary>
        /// <param name="teacher">The teacher.</param>
        void VisitTeacher(Teacher teacher);
    }
}
