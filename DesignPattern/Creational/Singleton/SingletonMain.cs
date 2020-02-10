// ******************************************************************************
//  <copyright file="SingletonMain.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  SingletonMain.cs
//  
//     Purpose:  Implementing Singleton design pattern
//     @author  Pranali Patil
//     @version 1.0
//     @since   3-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Creational.Singleton
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contain method to call the different methods from different singleton classes
    /// </summary>
    public class SingletonMain
    {
        /// <summary>
        /// this method is used to create objects of different classes
        /// </summary>
        public void SingletonMethods()
        {
            Console.WriteLine("\n Using Thread safe Singleton Initialization");
            
            // creating object of ThreadSingleton class by using it's GetSingleton method
            ThreadSingleton student = ThreadSingleton.GetSingleton();

            // accessing the StudentInfo from ThreadSingleton class
            student.StudentInfo();

            // creating another object of ThreadSingleton class by using it's GetSingleton method 
            ThreadSingleton teacher = ThreadSingleton.GetSingleton();

            // accessing the TeacherInfo from ThreadSingleton class
            teacher.TeacherInfo();

            Console.WriteLine("\n Using Lazy Initialization");

            // creating object of LazySingleton class
            LazySingleton lazyCompany = LazySingleton.GetLazySingleton();

            lazyCompany.CompanyInfo();

            // creating object of LazySingleton class
            LazySingleton lazyEmployee = LazySingleton.GetLazySingleton();
            lazyEmployee.CompanyInfo();
        }
    }
}
