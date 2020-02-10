// ******************************************************************************
//  <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Program.cs
//  
//     Purpose: Take user choice to perform different operations
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

    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            // flag variable indicates whether useer entered correct choice or not
            bool flag = false;

            // choice variable stores the choice entered by the user as the input
            int choice;

            while (flag == false)
            {
                try
                {
                    do
                    {
                        // reading user choice for performing operation
                        Console.WriteLine("\n 1.Replace UserName \n 2.Flip Coin \n 3.Leap Year \n 4.Power of Two \n 5.Harmonic Value \n 6.Prime Factors \n 7.Exit \n Enter Your Choice:");
                        choice = Convert.ToInt32(Console.ReadLine());

                        // perform operation as per user choice
                        switch (choice)
                        {
                            case 1:
                                // if user wants to replace name
                                ReplaceName replaceName = new ReplaceName();
                                replaceName.ReplaceUserName();

                                // flag indicates user entered correct choice
                                flag = true;
                                break;
                            case 2:
                                // if user wants to calculate head and tail percentage of coin fliping
                                FlipCoinPercentage f = new FlipCoinPercentage();
                                f.FlipCoin();

                                // flag indicates user entered correct choice
                                flag = true;
                                break;
                            case 3:
                                // if user wants to check leap year
                                LeapYear leapYear = new LeapYear();
                                leapYear.CheckLeapYear();

                                // flag indicates user entered correct choice
                                flag = true;
                                break;
                            case 4:
                                // if user wants to calculates power of two values for given number
                                PowerOfTwo powerofTwo = new PowerOfTwo();
                                powerofTwo.PrintPowerOfTwo();

                                // flag indicates user entered correct choice
                                flag = true;
                                break;
                            case 5:
                                // if user wants to calculate harmonic value of given number
                                HarmonicValue harmonicValue = new HarmonicValue();
                                harmonicValue.PrintHarmonicValue();

                                // flag indicates user entered correct choice
                                flag = true;
                                break;
                            case 6:
                                // if user wants to find prime factors of number
                                PrimeFactors primeFactors = new PrimeFactors();
                                primeFactors.PrintPrimeFactors();

                                // flag indicates user entered correct choice
                                flag = true;
                                break;
                            case 7:
                                // flag indicates user entered correct choice
                                flag = true;
                                break;
                            default:
                                Console.WriteLine("Wrong Choice.");
                                break;
                        }
                    }
                    while (choice != 7);
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
