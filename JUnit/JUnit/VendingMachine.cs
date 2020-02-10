/******************************************************************************
  *  Execution:    VendingMachine.cs
 *  
 *  Purpose: Find the Fewest Notes to be returned for Vending Machine
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
    class VendingMachine
    {
        /// <summary>
        ///Vending method reads the user input for how many rs user have.
        ///calculate and print the minimum number of notes to give change from vending machine to user
        /// </summary>
        public void Vending()
        {
            Utility utility = new Utility();
            //notes array type of variable contains notes value
            int[] notes = { 1, 2, 5, 10, 50, 100, 500, 1000 };
            int i = (notes.Length) - 1;
            int total=0;
            try
            {
                ///rs variable stores Rs. value to get change from vaending Machine
                Console.WriteLine("Enter Rs. to get change: ");
                int rs = Convert.ToInt32(Console.ReadLine());
                //rtotal variable stores count of no. of minimum notes required
                int rtotal=utility.GetChangeByvendingMachine(rs,notes,i, total);
                Console.WriteLine("\n Minimum number of notes: " + rtotal);
               
                Console.Write("\n Required Notes:\n");
                utility.printList();
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                Console.WriteLine("Please Enter correct Rs.");
            }
        }
    }
}
