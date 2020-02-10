/******************************************************************************
 *  Execution:    Program.cs
 *  Purpose:   take user choice to perform different operations
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   07-11-2019
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;

namespace FunctionalPrograms
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// Main method is used to take user choice to perform operations 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Boolean flag = false;
            while(flag==false)
            {
                //choice variable stores the choice of user 
                int choice;
                try
                {
                    do
                    {
                        //Read choice of Operations which user wants to perform 
                        Console.WriteLine("\n 1.Find Triplets \t 2.Distance \t 3.Quadratic \t 4.Wind Chill \t 5.2D Array \t 6.Exit\n Enter your Choice:");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                //if user wants to find triplets which exactly sum 0
                                SumOfThreeInt sumOfThreeInt = new SumOfThreeInt();
                                sumOfThreeInt.PrintSumOfThreeInt();
                                flag = true;
                                break;
                            case 2:
                                //if user wants to find Distance
                                Distance distance = new Distance();
                                distance.PrintDistance();
                                flag = true;
                                break;
                            case 3:
                                //if user wants to find roots of the equation
                                Quadratic quadratic = new Quadratic();
                                quadratic.PrintQuadratic();
                                flag = true;
                                break;
                            case 4:
                                //if user wants to calculate wind chill
                                WindChill wind = new WindChill();
                                wind.PrintWindChill();
                                flag = true;
                                break;
                            case 5:
                                //if user wants to Print values in 2D Array into file
                                TwoDArray twoDArray = new TwoDArray();
                                twoDArray.PrintTwoDArray();
                                flag = true;
                                break;
                            case 6:
                                //if user wants to Exit
                                flag = true;
                                break;
                            default:
                                Console.WriteLine("Please enter Correct Choice");
                                break;
                        }
                    } while (choice != 6);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Please enter Correct Choice");
                    flag = false;
                }
                
            }
            Console.ReadKey();
        }
    }
}
