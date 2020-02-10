// ******************************************************************************
//  <copyright file="LeapYear.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  LeapYear.cs
//  
//     Purpose: Determines whether the year is Leap Year or not 
//     @author  Pranali Patil
//     @version 1.0
//     @since   07-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace BasicProgram
{   
    /// Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contains method to check whether given year is leap year or not
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// this method is used take year entered by user and check user entered year is in proper format or no
        /// if its in proper format then checks the year is leap year or not.
        /// </summary>
        public void CheckLeapYear()
        {
            // creating utility class object to access methods from it
            Utility utility = new Utility();
            try
            {
                // year variable stores the user entered year to check it's leap year or not
                int year;

                // take user input for year
                Console.WriteLine("Enter any year: ");
                year = Convert.ToInt32(Console.ReadLine());

                // check digits in user entered year
                int count = utility.CountDigit(year);

                // check user entered year is 4 digit or not
                if (count == 4)
                {
                    // check year is leap or not
                    bool result = utility.IsLeap(year);
                    if (result)
                    {
                        Console.WriteLine("Given Year is Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("Given Year is Not Leap Year");
                    }                       
                }
                else
                {
                    Console.WriteLine("Please enter Correct Year");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }      
    }
}
