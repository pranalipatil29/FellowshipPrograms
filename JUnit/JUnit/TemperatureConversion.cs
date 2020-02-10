/******************************************************************************
  *  Execution:    TemperatureConversion.cs
 *  
 *  Purpose: Convert temperature Fahrenheit to Celsius or viceVersa
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
    class TemperatureConversion
    {
        /// <summary>
        /// PrintTemprature method takes celcius and Fahrenheit temperature and
        /// prints temperature after converting celcius to Fahrenheit and Fahrenheit to celcius
        /// </summary>
        public void PrintTemprature()
        {
            Utility utility = new Utility();
            try
            {
                //ftemp stores Fahrenheit temperature and ctemp stores Celsius temperature
                double ftemp, ctemp; 
                Console.WriteLine("Enter Fahrenheit Temperature: ");
                ftemp = Convert.ToDouble(Console.ReadLine());
                utility.ConverToCelcius(ftemp);
               
                Console.WriteLine("\nEnter Celsius Temperature: ");
                ctemp = Convert.ToDouble(Console.ReadLine());
                utility.ToFahrenheit(ctemp);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter Correct Temperature");
            }
        }
    }
}
