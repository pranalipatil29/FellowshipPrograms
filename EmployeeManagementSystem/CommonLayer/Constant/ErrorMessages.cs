// ******************************************************************************
//  <copyright file="ErrorMessages.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  ErrorMessages.cs
//  
//     Purpose: display different messages 
//     @author  Pranali Patil
//     @version 1.0
//     @since  7 -12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************
namespace CommonLayer.Constant
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contains different messages for defferent operations
    /// </summary>
    public class ErrorMessages
    {
        /// <summary>
        /// This message is used when data gets added
        /// </summary>
        public static string Added = "Data Successfully Added";

        /// <summary>
        /// This message is used when data gets updated
        /// </summary>
        public static string Updated = "Data is Updated Successfully";

        /// <summary>
        ///  This message is used when data gets deleted
        /// </summary>
        public static string Deleted = "Data is Deleted Successfully";

        /// <summary>
        ///  This message is used when data is invalid
        /// </summary>
        public static string Invalid = "Invalid Data";

        /// <summary>
        ///  This message is used when data is not found
        /// </summary>
        public static string NotFound = "Employee Not Found";
    }
}
