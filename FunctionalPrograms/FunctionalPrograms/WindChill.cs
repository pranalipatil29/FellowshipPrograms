/******************************************************************************
 *  Execution:    WindChill.cs
 *  Purpose: Print the WindChill 
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   07-11-2019
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class WindChill
    {
        /// <summary>
        /// PrintWindChill method takes temperature and speed of wind from user and Prints the wind chill.
        /// </summary>
        public void PrintWindChill()
        {
            try
            {
                //t and v variable takes temperature and speed of wind entered by user
                Utility utility = new Utility();
                double t, v;
                Console.WriteLine("Enter temperature below 50 °F & Wind Speed >2: ");
                t = Convert.ToDouble(Console.ReadLine());
                v = Convert.ToDouble(Console.ReadLine());
                utility.CalWindChill(t, v);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter Correct values");
            }
        }
    }
}
