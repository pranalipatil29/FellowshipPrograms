// ******************************************************************************
//  <copyright file="LibrarySystem.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  LibrarySystem.cs
//  
//     Purpose:  Implementing Library System
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
    /// Defines the entry point in library system
    /// </summary>
    public class LibrarySystem
    {
        /// <summary>
        /// this method is used to maintain the library system
        /// </summary>
        public void Library()
        {
            // creating LibraryFacade class object
            LibraryFacade libraryFacade = new LibraryFacade();

            // maintaining the library system through facade class object
            libraryFacade.MaintainLibrary();
        }
    }
}
