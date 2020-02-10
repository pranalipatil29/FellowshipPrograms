//  ******************************************************************************
//  <copyright file="UtilityCalandar.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  UtilityCalandar.cs
//  
//     Purpose:    Generating calandar using Queue
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
    ///  this class contains methods to generate calendar 
    /// </summary>
    public class UtilityCalandar
    {
        /// <summary>
        /// The week queue
        /// </summary>
        public Queueusinglinkedlist<string> weekQueue = new Queueusinglinkedlist<string>();

        /// <summary>
        /// The month queue
        /// </summary>
        public Queueusinglinkedlist<int> monthQueue = new Queueusinglinkedlist<int>();

        /// <summary>
        /// The calendar
        /// </summary>
        public Queueusinglinkedlist<int> calendar = new Queueusinglinkedlist<int>();

        /// <summary>
        /// The months
        /// </summary>
        public string[] Months = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };

        /// <summary>
        /// The dates
        /// </summary>
        public int[] Dates = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        /// <summary>
        /// The week
        /// </summary>
        public string[] Week = { "Sun", "Mon", "Tue", "Wed", "The", "Fri", "Sat" };

        /// <summary>
        /// Determines whether [is leap year] [the specified year].
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if [is leap year] [the specified year]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsLeapYear(int year)
        {
            // checks condition for leap year
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                // if condition for leap year is true then return true indicating that year is leap year
                return true;
            }
            else
            {
                // return false indicating year is not leap yaer
                return false;
            }
        }

        /// <summary>
        /// Calculates the day of week.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="month">The month.</param>
        /// <param name="year">The year.</param>
        /// <returns> returns the first day of month </returns>
        public int CalculateDayOfWeek(int date, int month, int year)
        {
            // creating variables for storing the values of year,month,and starting day of month
            int years, months, temp, day;

            // finding the starting day of given month
            years = year - (14 - month) / 12;
            temp = years + years / 4 - years / 100 + years / 400;
            months = month + 12 * ((14 - month) / 12) - 2;
            day = (date + temp + 31 * months / 12) % 7;

            // returning the first day of given month
            return day;
        }

        /// <summary>
        /// Generates the calendar.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="month">The month.</param>
        /// <param name="year">The year.</param>
        public void GenerateCalendar(int day, int month, int year)
        {
            // creating array to store calendar of month
            int[,] calendarArray = new int[6, 7];

            // starting row from 0
            int row = 0;

            // start column from day value
            int column = day;

            for (int i = 0; i < day; i++)
            {
                this.monthQueue.EnQueue('\0');
            }

            // date variable is used to indicate date in month
            int date = 1;

            // storing days in weekQueue
            for (int i = 0; i < Week.Length; i++)
            {
                this.weekQueue.EnQueue(Week[i]);
            }

            // repetes the loop till 6 rows bcz each month in calendar having 6 rows
            while (row < 6)
            {
                // second while loop repetes till coulumn counter becomes 7 and all dates in given month are stored in array
                while (column < 7 && date <= this.Dates[month])
                {
                    // store date in calendar queue
                    this.monthQueue.EnQueue(date);

                    // incremenet date counter
                    date++;

                    // increment column counter to go next day in month
                    column++;
                }

                // if column counter becomes 7 it goes to next row so again start column from 0
                column = 0;

                // if column counter become 7 then row must increment
                row++;

                // check whether date is greater than dates in given month
                if (date > this.Dates[month])
                {
                    // repeate the loop till 7'th column
                    while (column < 7)
                    {
                        // add 0's to remeaning places in array
                        this.monthQueue.EnQueue('\0');
                        column++;
                    }

                    // if column counter becomes 7 it goes to next row so again start column from 0
                    column = 0;

                    // increment row counter
                    row++;
                }
            }

            Console.WriteLine(" " + month + " " + year + " \n");

            // for loop is used to print days of week
            for (int i = 0; i < Week.Length; i++)
            {
                // prints the days of week
                Console.Write(weekQueue.DeQueue() + "\t");
            }

            Console.Write("\n");

            int data = 0;

            // first for loop is used for rows in Calendar array
            for (int i = 0; i < 6; i++)
            {
                // second for loop is used for each column in Calendar array
                for (int j = 0; j < 7; j++)
                {
                    // printing values in calendar array
                     data = this.monthQueue.DeQueue();
                    Console.Write(data + "\t");
                }

                if (data.Equals(0))
                {
                    break;
                }

                // if column becomes 7 then print next row to next line
                Console.Write("\n");
            }
        }
    }
}
