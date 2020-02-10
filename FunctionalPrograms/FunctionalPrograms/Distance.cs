/******************************************************************************
 *  Execution:    Distance.cs
 *  Purpose: Prints the Euclidean distance from the point (x, y) to the origin (0, 0).
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
   public class Distance
    {
        /// <summary>
        /// PrintDistance method is used to take x and y points from user
        /// and prints the distance between two Points.
        /// </summary>
        public void PrintDistance()
        {
            try
            {
                Utility utility = new Utility();
                //x and y variables stores the value of x2 and y2 points
                int x, y;
                Console.WriteLine("Enter Value for x & y: ");
                x = Convert.ToInt32(Console.ReadLine());
                y= Convert.ToInt32(Console.ReadLine());
                utility.CalDistance(x, y);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Correct int Number");
            }
        }
    }
}
