/******************************************************************************
  *  Execution:    DayOfWeek.cs
 *  
 *  Purpose: Print Day of Week
 *
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   09-11-2019
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;
using System.Collections.Generic;
using System.Text;

namespace JUnit
{
    class DayOfWeek
    {
        /// <summary>
        /// printDayOfWeek method takes date,year and month from user and prints the day of that date
        /// </summary>
        public void printDayOfWeek()
        {
            Utility utility = new Utility();
            //d variable stores date value
            //m variable stores month value
            //y variable stores year value
            int d, m, y;
            try
            {
                //read value for d,m and y from user
                Console.WriteLine("Enter Year: ");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter month: ");
                m = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Day: ");
                d = Convert.ToInt32(Console.ReadLine());
                //find day of week by given value
                utility.FindDayOfWeek(d, m, y);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please Enter Correct month,year and day");
            }
        }
        
    }
}
