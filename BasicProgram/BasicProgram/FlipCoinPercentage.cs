// ******************************************************************************
//  <copyright file="FlipCoinPercentage.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Program.cs
//  
//     Purpose:  Flip Coin and print percentage of Heads and Tails
//     @author  Pranali Patil
//     @version 1.0
//     @since   07-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace BasicProgram
{
    /// Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contains methods to calculate percentage of head and tails
    /// </summary>
    public class FlipCoinPercentage
    {
        /// <summary>
        /// creating Utility class object to access methods from that class
        /// </summary>
        private Utility utility = new Utility();

        /// <summary>
        /// FlipCoin method used to know how many times user wants to flip the 
        /// coin and print the percentage of heads and tails
        /// </summary>
        public void FlipCoin()
        {           
            try
            {
                // count variable is used to indicate how many times user want to flip the coin
                int count = 0;
                Console.WriteLine("Enter How many times you want to flip a Coin: ");
                count = Convert.ToInt32(Console.ReadLine());
                this.utility.FlipCoinPerc(count);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            } 
        }     
    }
}
