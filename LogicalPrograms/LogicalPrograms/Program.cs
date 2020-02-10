// ******************************************************************************
//  <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Program.cs
//  
//     Purpose:Perform different operations according to user choice
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

    /// <summary>
    ///  Defines the entry point of the application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// main method takes user choice to perform different types of operations
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            // flag is used to indicate whether user entered choice is correct or not
            Boolean flag = false;

            // iterates the loop till user enter correct choice
            while (flag == false)
            {
                // choice variable stores user choice to perform operation
                int choice;
                try
                {
                    do
                    {
                        // Reads user choice to perform operation
                        Console.WriteLine("\n1.Gambler \t 2.Coupon Numbers \t 3.StopWatch \t 4.Tic Tac Toe \t 5.Exit\n Enter your Choice");
                        choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                // if user wants to play Gambler
                                Gambler gambler = new Gambler();
                                gambler.GamblerResult();
                                flag = true;
                                break;
                            case 2:
                                // if user wants to generate coupon number
                                CouponNumber couponNumber = new CouponNumber();
                                couponNumber.ProcessdistinctCoupon();
                                flag = true;
                                break;
                            case 3:
                                // if user wants to calculate Elapsed Time
                                Stopwatch stopwatch = new Stopwatch();
                                stopwatch.StartStopWatch();
                                flag = true;
                                break;
                            case 4:
                                // if user wants to play Tic-Tac-toe game
                                Tic_Tac_Toe tic = new Tic_Tac_Toe();
                                tic.StartPlaying();
                                flag = true;
                                break;
                            case 5:
                                // if user wants to exit
                                flag = true;
                                break;
                            default:
                                Console.WriteLine("Please Enter Correct Choice");
                                break;
                        }
                    }
                    while (choice != 5);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
