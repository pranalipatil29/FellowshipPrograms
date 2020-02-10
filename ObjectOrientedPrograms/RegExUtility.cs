// ******************************************************************************
//  <copyright file="RegExUtility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  RegExUtility.cs
//  
//     Purpose:  implements methods for Regular Expression.
//     @author  Pranali Patil
//     @version 1.0
//     @since   28-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// this class contains different methods to check user input
    /// </summary>
    public class RegExUtility
    {
        /// <summary>
        /// Determines whether user given name is proper name or not.
        /// </summary>
        /// <param name="fullName">The full name holds value of user given name.</param>
        /// <returns>
        ///   <c>true</c> if user given name is in proper format otherwise, <c>false</c>.
        /// </returns>
        public bool IsFullName(string fullName)
        {
            // check user enter name is in proper format or not
            if (Regex.Match(fullName, "^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines whether user given number is proper contact number or not.
        /// </summary>
        /// <param name="number">The number holds user given value.</param>
        /// <returns>
        ///   <c>true</c> if user given contact number is in correct format; otherwise, <c>false</c>.
        /// </returns>
        public bool IsContactNumber(string number)
        {
            if (Regex.IsMatch(number, @"^[0-9]{10}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines whether the specified number is number or not.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>
        ///   <c>true</c> if the specified number is number; otherwise, <c>false</c>.
        /// </returns>
        public bool IsNumber(string number)
        {
            if (Regex.Match(number, "^[0-9]+$").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines whether user given name is in correct city name format.
        /// </summary>
        /// <param name="cityName">Name of the city.</param>
        /// <returns>
        ///   <c>true</c> if [is city name] [the specified city name]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsCityName(string cityName)
        {
            if (Regex.Match(cityName, "^[a-zA-Z]+(?:[\\s-][a-zA-Z]+)*$").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
