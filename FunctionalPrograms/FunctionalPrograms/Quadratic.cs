/******************************************************************************
 *  Execution:    Quadratic.cs
 *  Purpose: find roots of the equation a*x*x+b*x+c.
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
    class Quadratic
    {
        /// <summary>
        /// PrintQuadratic method is used to take 3 values from user and Prints
        ///the quadratic roots of the given equation
        /// </summary>
        public void PrintQuadratic()
        {
            try
            {
                Utility utility = new Utility();
                //take values for a,b,c
                double a, b, c;
                Console.WriteLine("Enter Values for a,b and c: ");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                utility.FindQuadraticRoots(a, b, c);
            }
            catch(Exception e)
            {
                Console.Write("Please Enter Correct Values");
            }
        }
    }
}
