// ******************************************************************************
//  <copyright file="CalendarUsingStack.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  CalendarUsingStack.cs
//  
//     Purpose:   Print calendar using stack
//
//     @author  Pranali Patil
//     @version 1.0
//     @since   5-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
//
// ******************************************************************************/
namespace DataStructurePrograms.CalendarStack
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Defines entry point
    /// </summary>
    public class CalendarUsingStack
    {
        /// <summary>
        /// Prints the calendar.
        /// </summary>
        public void PrintCalendar()
        {
            // creating UtilityCalandar class object
            CalendarStack.CalendarUtility calendarUtility = new CalendarUtility();

            // creating Utility class object
            Utility utility = new Utility();

            try
            {
                int month, year;
                
                // reading values for month and year from user
                Console.WriteLine("Enetr Month: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Year: ");
                year = Convert.ToInt32(Console.ReadLine());

                // checks whether the user entered month and year are in correct or not
                if (month < 0 || year < 0 || month > 12)
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

                    // GenerateCalendar method is used to generate the month calender and print it
                    int[,] calendar = utility.GenerateCalendar(day, month, year);

                    calendarUtility.PrintCalendar(calendar);
                }
            }
            catch (Exception exception)
            {
                 throw new Exception(exception.Message);
            }
        }
    }
}