// ******************************************************************************
//  <copyright file="MainClass.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  MainClass.cs
//  
//     Purpose:  Implementing program to use reflection
//     @author  Pranali Patil
//     @version 1.0
//     @since   2-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Reflection
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// Gets the information of Employee class.
        /// </summary>
        public void GetInfoOfClass()
        {
            // geting type of Employee class
            Type type = Type.GetType("DesignPattern.Reflection.Employee");

            Console.WriteLine("Employee Class Info");

            // printing full name of employee class
            Console.WriteLine("Full Name: " + type.FullName);

            // printing info of assembly
            Console.WriteLine("\nAssembly info :\n" + type.Assembly);

            // geting all properties used in class
            PropertyInfo[] properties = type.GetProperties();

            Console.WriteLine("\n Property Info");

            // repeate the loop for all properties in employee class
            foreach (PropertyInfo property in properties)
            {
                // printing property info
                Console.WriteLine(property.PropertyType.Name + " : " + property.Name);
            }

            Console.WriteLine("\n Methods info ");

            // geting all methods in class
            MethodInfo[] methods = type.GetMethods();

            // repeate the loop for all methods in employee class
            foreach (MethodInfo method in methods)
            {
                // printing method info
                Console.WriteLine("Method name : " + method.Name + "\n Return type: " + method.ReturnType);
            }
        }
    }
}
