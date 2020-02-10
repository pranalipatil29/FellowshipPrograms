// ******************************************************************************
//  <copyright file="ConcreateVisitor.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  ConcreateVisitor.cs
//  
//     Purpose:  Implementing concreate visitor
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
    /// this class contains methods for concreate visitor
    /// </summary>
    /// <seealso cref="DesignPattern.Behavioral.Visitor.IVisitor" />
    public class ConcreateVisitor : IVisitor
    {
        /// <summary>
        /// Visits the student.
        /// </summary>
        /// <param name="student">The student.</param>
        public void VisitStudent(Student student)
        {
            Console.WriteLine("Student Name : " + student.StudentName());        
        }

        /// <summary>
        /// Visits the teacher.
        /// </summary>
        /// <param name="teacher">The teacher.</param>
        public void VisitTeacher(Teacher teacher)
        {
            Console.WriteLine("Teacher Name : " + teacher.TeacherName());
        }
    }
}
