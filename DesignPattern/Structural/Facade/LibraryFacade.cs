// ******************************************************************************
//  <copyright file="LibraryFacade.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  LibraryFacade.cs
//  
//     Purpose:  Implementing Facade Design Pattern for library System
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
    /// this class is used to implement facade design pattern for library system
    /// </summary>
    public class LibraryFacade
    {
        /// <summary>
        /// creating reference of technical book
        /// </summary>
        private TechnicalBooks technicalBooks;

        /// <summary>
        /// creating reference of novels book 
        /// </summary>
        private Novels novels;

        /// <summary>
        ///  creating reference of comic books
        /// </summary>
        private Comicbooks comicbooks;

        /// <summary>
        ///  creating reference for book entry
        /// </summary>
        private BooksEntry booksEntry;

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryFacade"/> class.
        /// </summary>
        public LibraryFacade()
        {
            // Initializes a new instance of technical books
            this.technicalBooks = new TechnicalBooks();

            // Initializes a new instance of Novels
            this.novels = new Novels();

            // Initializes a new instance of Comic Books
            this.comicbooks = new Comicbooks();

            // Initializes a new instance for book entry
            this.booksEntry = new BooksEntry();
        }

        /// <summary>
        /// Maintains the library.
        /// </summary>
        public void MaintainLibrary()
        {
            Console.WriteLine("\n Updating Library System \n");
            this.technicalBooks.AddTechnicalBooks();
            this.comicbooks.AddComicbooks();
            this.novels.AddNovels();
           this.booksEntry.AddEntry();
            Console.WriteLine("\n Library System is Updated \n");
        }
    }
}
