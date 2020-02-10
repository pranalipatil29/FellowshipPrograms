/******************************************************************************
  *  Execution:    MonthlyPayment.cs
 *  
 *  Purpose: Calculate Monthly Payment
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
    class MonthlyPayment
    {
        Utility utility = new Utility();
        /// <summary>
        /// PrintMonthlyPayment method takes principal loan amount, number of years to pay that amount and rate  per cent fro user
        /// calculate and prints the monthly payment of user
        /// </summary>
        public void PrintMonthlyPayment()
        {
            try
            {
                //p variable stores Principle amount and r variable stores Rate Per cent value
                double p,r;
                //y variable stores number of years
                int y;
                Console.WriteLine("Enter Principal Loan Amount: ");
                p = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Rate per cent: ");
                r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter number of year: ");
                y = Convert.ToInt32(Console.ReadLine());
                //calculate monthly payment of user
                utility.CalMonthlyPayment(p,r,y);

            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter correct values");
            }
        }
    }
}
