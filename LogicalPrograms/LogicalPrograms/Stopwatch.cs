// ******************************************************************************
//  <copyright file="StopWatch.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  StopWatch.cs
//  
//     Purpose:  Calculate Elapsed time between start and stop clicks
//     @author  Pranali Patil
//     @version 1.0
//     @since    08-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace LogicalPrograms
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// this class contains methods to print elapsed time
    /// </summary>
    class Stopwatch
    {
        /// <summary>
        /// StartStopWatch method is used to print the elapsed time
        /// </summary>
        public void StartStopWatch()
        {
            // creating ustility class object to access methods from that class
            Utility utility = new Utility();

            // choice variable takes value when to stop the stopWatch
            int choice = 0;
            Boolean flag = false;
           
            while (flag == false)
            {
                try
                {
                    DateTime now = DateTime.Now;
                    Console.WriteLine("StopWatch Started....");
                    Console.WriteLine("\nstarting time= " + now.TimeOfDay);
                  
                    // takes user input to stop the stopwatch
                    Console.Write("\nEnter 1 when you want to Stop the Stop Watch: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        flag = true;
                        DateTime newtime = DateTime.Now;
                        Console.WriteLine("\nstoped time= " + newtime.TimeOfDay);
                        utility.CalElapsedTime(now, newtime);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }   
        }      
    }
}
