// ******************************************************************************
//  <copyright file="Calendar.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Calendar.cs
//  
//     Purpose: Calendar class is used to print the Calendar of Month stored in 2D Array.
//
//     @author  Pranali Patil
//     @version 1.0
//     @since   20-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DataStructurePrograms
{
    /// Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Calendar class contains methods for printing calendar of the month
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// PrintCalendar method Prints the calendar stored in 2D array.
        /// </summary>
        public void PrintCalendar()
        {
            // creating Utility class object to access methods from utility class
            Utility utility = new Utility();
            try
            {
                // month and year variables is used to store user entered month and year value
                int month, year;

                // taking values for month and year from user
                Console.WriteLine("Enetr Month: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Year: ");
                year = Convert.ToInt32(Console.ReadLine());

                // checks whether the user entered month and year are in correct or not
                if (month < 0 || year < 0)
                {
                    Console.WriteLine("Please enter correct month or year");
                }
                else
                {
                    // check whether user entered month is 2 and year is leap year or not
                    if (month == 2 && utility.IsLeapYear(year))
                    {
                        // if yes then assign 29 days for Feb month
                        utility.Dates[month] = 29;
                    }

                    // calculate First Day of month
                    int day = utility.CalculateDayOfWeek(1, month, year);

                    // GenerateCalendar method is used to generate the month calender
                    utility.GenerateCalendar(day, month, year);
                    int[,] calender = utility.GenerateCalendar(day, month, year);

                    Console.WriteLine(" " + month + " " + year + " \n");
                    
                    // for loop is used to print days of week
                    for (int i = 0; i < utility.Week.Length; i++)
                    {
                        // prints the days of week
                        Console.Write(utility.Week[i] + "\t");
                    }

                    Console.Write("\n");

                    // printing calendar of given month
                    // first for loop is used for rows in Calendar array
                    for (int i = 0; i < 6; i++)
                    {
                        // second for loop is used for each column in Calendar array
                        for (int j = 0; j < 7; j++)
                        {
                            // printing values in calendar array
                            Console.Write(calender[i, j] + "  \t ");
                        }

                        // if column becomes 7 then print next row to next line
                        Console.Write("\n");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

                // throw new Exception(exception.Message);
            }
        }
    }
}
