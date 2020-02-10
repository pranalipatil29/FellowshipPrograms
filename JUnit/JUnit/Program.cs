/******************************************************************************
  *  Execution:    Program.cs
 *  
 *  Purpose: Take user choice to Perform different operations 
 *
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   09-11-2019
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;

namespace JUnit
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// main method takes user choice to perform the different operations
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Boolean flag = false;
            while(flag==false)
            {
                try
                {
                    //choicce variable stores user choice to perform the operations
                    int choice;
                    do
                    {
                        Console.WriteLine("\n 1.Vending machine \t 2.DayofWeek \t 3.Temperature Conversion \t 4.Monthly Payment \n"+
                            " 5.Sqrt of number \t 6.Decimal To Binary \t 7.Binary to Decimal \t 8.Exit \n Enter your Choice ");
                        choice = Convert.ToInt32(Console.ReadLine());

                        switch(choice)
                        {
                            case 1 :
                                //if user wants to take change by vanding machine
                                VendingMachine vendingMachine = new VendingMachine();
                                vendingMachine.Vending();
                                flag = true;
                                break;
                            case 2 :
                                //if user wants to know day of Week
                                DayOfWeek dayOf = new DayOfWeek();
                                dayOf.printDayOfWeek();
                                flag = true;
                                break;
                            case 3 :
                                //if user wants to convert the temperature
                                TemperatureConversion tconversion = new TemperatureConversion();
                                tconversion.PrintTemprature();
                                flag = true;
                                break;
                            case 4 :
                                //if user wants to calculate Monthly payment
                                MonthlyPayment monthlyPayment = new MonthlyPayment();
                                monthlyPayment.PrintMonthlyPayment();
                                flag = true;
                                break;
                            case 5 :
                                //if user wants to find Sqrt of number
                                SqrtOfNumbercs sqrtOfNumbercs = new SqrtOfNumbercs();
                                sqrtOfNumbercs.PrintSqrtOfNumber();
                                flag = true;
                                break;
                            case 6:
                                //if user wants to find binary number of given decimal number
                                DecimalToBinary decimalToBinary = new DecimalToBinary();
                                decimalToBinary.PrintBinary();
                                flag = true;
                                break;
                            case 7 :
                                //if user wants to know decimal number of binary number
                                Binary binary = new Binary();
                                binary.SwapBinaryNum();
                                flag = true;
                                break;
                            case 8:
                                //if user wants to exit
                                flag = true;
                                break;
                            default :
                                Console.WriteLine("Wrong Choice");
                                flag = true;
                                break;
                        }
                    } while (choice != 8);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Please Enter correct Choice");
                }
            }
            Console.ReadKey();
        }
    }
}
