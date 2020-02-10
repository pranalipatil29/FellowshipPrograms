/******************************************************************************
 *  Execution:    TwoDArray.cs 
 *  Purpose: Take user choice to determine which type of 2 D Array user wants to print
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
    class TwoDArray
    {
        /// <summary>
        /// PrintTwoDArray method is used to read and store elements in two D array 
        /// accourding to user choice for which type of elements user wants to store in array
        /// </summary>
        public void PrintTwoDArray()
        {
            //flag variable is used to determine whether user enter correct choice or not
            Boolean flag = false;               
            Utility utility = new Utility();
            //choice variable stores user entered choice
            int choice,x, y;                        
            while (flag == false)
            {
                try
                {
                    do
                    {
                        //takes user choice in choice variable for which type of array elements user wants to enter in array
                        Console.WriteLine("\n1.Integer Array \t 2.Double Array \t 3.Boolean Array \t 4.Exit\nEnter Your Choice:");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                //if user wants to Print integer type of elements in array
                                Console.WriteLine("Enter Values for x & y: ");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                int[,] arr = utility.GetIntTwoDAray(x, y);
                                utility.PrintIntTwoDArray(arr, x, y);
                                flag = true;
                                break;
                            case 2:
                                //if user wants to print double Type elements in Array
                                Console.WriteLine("Enter Values for x & y: ");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                double[,] doubleTwoDArray = utility.GetDoubleTwoDArray(x, y);
                                utility.PrintDoubleTwoDArr(doubleTwoDArray, x, y);
                                flag = true;
                                break;
                            case 3:
                                //if user wants to print Boolean type of eloements in array
                                Console.WriteLine("Enter Values for x & y: ");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                Boolean[,] booleanTwoDArray = utility.GetBooleanTwoDArray(x, y);
                                utility.PrintDoubleTwoDArr(booleanTwoDArray, x, y);
                                flag = true;
                                break;
                            case 4:
                                //if user want to exit
                                flag = true;
                                break;
                            default:
                                Console.WriteLine("Please enter correct Choice");
                                break;
                        }
                    } while (choice != 4);


                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Enter Correct Values");
                }

            }

        }
    }
}
