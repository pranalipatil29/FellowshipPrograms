// ******************************************************************************
//  <copyright file="VisitorMain.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  VisitorMain.cs
//  
//     Purpose:  Implementing Visitor Design Pattern
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
    ///  Defines the entry point in Visitor design pattern
    /// </summary>
    public class VisitorMain
    {
        /// <summary>
        /// Starts the visiting.
        /// </summary>
        public void StartVisiting()
        {
            // geting objects info in list
            List<ISchool> school = new List<ISchool>
            {
                new Student(),
                new Teacher()
            };

            // accessin methods through visitor
            Console.WriteLine("Visitor Access data form School");
            var newVisitor = new ConcreateVisitor();
            Client.AccessData(school, newVisitor);
        }
    }
}
