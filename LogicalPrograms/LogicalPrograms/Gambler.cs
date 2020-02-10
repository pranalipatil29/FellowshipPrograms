// ******************************************************************************
//  <copyright file="gambler.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  gambler.cs
//  
//     Purpose:  Prints the number of wins and loss of gambler
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

    /// <summary>
    /// this class contains methods to play gambler game
    /// </summary>
    class Gambler
    {
        /// <summary>
        /// GamblerResult method is used to take information from user to play the gambler game
        /// and prints the how msny times user win and loss the game
        /// </summary>
        public void GamblerResult()
        {
            Utility utility = new Utility();
            // limit variable stores how many time user want to play
            // stake variable stores value of stake user has
            // goal variable stores user goal value
            int limit, stake, goal;

            try
            {
                // reading values from user
                Console.WriteLine("Enter How many times you want to play:");
                limit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Value for Stake:");
                stake = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your goal Value:");
                goal = Convert.ToInt32(Console.ReadLine());

                // checking whether user win the game or loss the game
                utility.CheckgamblerWinOrLoss(limit, stake, goal);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
