// ******************************************************************************
//  <copyright file="BooksEntry.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  BooksEntry.cs
//  
//     Purpose:  Maintaining Books entry in library
//     @author  Pranali Patil
//     @version 1.0
//     @since   4-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/

namespace DesignPattern.Structural.Facade
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  this class is used to maintain books entry
    /// </summary>
    public class BooksEntry
    {
        /// <summary>
        /// Adds the book entry.
        /// </summary>
        public void AddEntry()
        {
            Console.WriteLine("Adding Book entry in system");
        }
    }
}
