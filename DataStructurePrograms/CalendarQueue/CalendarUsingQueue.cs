//  ******************************************************************************
//  <copyright file="CalendarUsingQueue.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  CalendarUsingQueue.cs
//  
//     Purpose:   Print Calandar using queue
//  
//     @author  Pranali Patil
//     @version 1.0
//     @since   20-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// 
//   ******************************************************************************/
namespace DataStructurePrograms.CalendarQueue
{
    // Including the requried assemblies in to the program  
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  this class contains method to print calendar of given month
    /// </summary>
    public class CalendarUsingQueue
    {
        /// <summary>
        /// Prints the calendar.
        /// </summary>
        public void PrintCalendar()
        {
            // creating UtilityCalandar class object
            CalendarQueue.UtilityCalandar utility = new CalendarQueue.UtilityCalandar();

            try
            {
                int month, year;
                
                // reading values for month and year from user
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

                    // GenerateCalendar method is used to generate the month calender and print it
                    utility.GenerateCalendar(day, month, year);
                }
            }
            catch (Exception exception)
            {
                 throw new Exception(exception.Message);
            }
        }
    }
}
