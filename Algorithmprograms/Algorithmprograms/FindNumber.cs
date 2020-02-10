/******************************************************************************
 *  Execution:    FindNumber.cs
 *  
 *  Purpose:Take user choice to perform operation 
 *
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   13-11-2019
 *
 ******************************************************************************/
/// Including the requried assemblies in to the program
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithmprograms
{
    class FindNumber
    {
        public void GuessNumber()
        {
            Utility utility = new Utility();
            try
            {
                int no;
                Console.WriteLine("Enter number: ");
                no = Convert.ToInt32(Console.ReadLine());
                int range = Convert.ToInt32(Math.Pow(2, no));
                Console.WriteLine("Guess any nuber from 0 to" + (range-1));
                int first = 0, last = range-1;
                int mid = (last - first) / 2;
                utility.GuessNumberByBinarySearch(first,mid,last);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter Correct Number");
            }
        }
    }
}
