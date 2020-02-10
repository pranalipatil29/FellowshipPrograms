// ******************************************************************************
//  <copyright file="CalendarUtility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  CalendarUtility.cs
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
    /// Contains methods to print calendar
    /// </summary>
    public class CalendarUtility
    {
        /// <summary>
        /// The week stack to holds days
        /// </summary>
        public StackUtility<string> weekStack = new StackUtility<string>();

        /// <summary>
        /// The month queue
        /// </summary>
        public StackUtility<int> monthStack = new StackUtility<int>();

        /// <summary>
        /// The calendar
        /// </summary>
       public StackUtility<int> calendar = new StackUtility<int>();

        /// <summary>
        /// The utility class object
        /// </summary>
        Utility utility = new Utility();

        /// <summary>
        /// Prints the calendar.
        /// </summary>
        /// <param name="calendar">The calendar.</param>
        public void PrintCalendar(int[,] calendar)
        {
            // itearte loop for adding all days in week stack
            for (int i = utility.Week.Length - 1; i >= 0; i--)
            {
                this.weekStack.Push(utility.Week[i]);
            }

            //// Printing Week days
            // iterate loop to print the days of week
            for (int i = 0; i < utility.Week.Length; i++)
            {
                Console.Write(this.weekStack.Pop() + "\t");
            }

            Console.WriteLine("\n");

            // iterates loop for all rows in calenndar
            for (int i = 5; i >= 0; i--)
            {
                // iterates loop for all column in calendar
                for (int j = 6; j >= 0; j--)
                {
                    // adding date in calendar array in stack
                    this.monthStack.Push(calendar[i, j]);
                }
            }

            // iterates loop for all rows in calenndar
            for (int i = 0; i < 6; i++)
            {
                // iterates loop for all column in calendar
                for (int j = 0; j < 7; j++)
                {
                    // printing 
                    Console.Write(this.monthStack.Pop() + "\t");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
