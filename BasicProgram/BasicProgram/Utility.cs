// ******************************************************************************
//  <copyright file="Utility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Program.cs
//  
//     Purpose:  Contains all the methods and variables which are used to perform different operations
//     @author  Pranali Patil
//     @version 1.0
//     @since   07-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace BasicProgram
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// the Utility class contains different methods to perform different types of operations
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// CheckLength method is used to check user entered name have at least 3 characters 
        /// </summary>
        /// <param name="userName"> this parameter is holding user entered name</param>
        /// <returns> returns true if user name length is not less than 3</returns>
        public bool CheckLength(string userName)
        {
            // check user entered name length is more than 2 
            if (userName.Length > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ReplaceName method is used to replace user entered name with name in message
        /// </summary>
        /// <param name="userName"> This parameter holds the user name entered by user.</param>
        /// <returns> this method returns the message after replacing user name </returns>
        public string RplaceName(string userName)
        {
            string message;
            message = "Hello <<UserNmae>>,How are you?";
            message = message.Replace("<<UserNmae>>", userName);
            return message;
        }

        /// <summary>
        /// this method is used to calculate count of heads and tails
        /// </summary>
        /// <param name="count"> this variable indicates how many times user wants to flip the coin</param>
        public void FlipCoinPerc(int count)
        {
            // creating object of random class
            Random r = new Random();

            // head and tail variables is used to indicate the head count and tails count
            int heads = 0, tails = 0, i = count;

            // iterates the loop till for user entered limit to flip the coin
            while (i > 0)
            {
                // if random number is less than 0.5 means it's head otherwise increment tails counter
                if (r.NextDouble() < 0.5)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }

                i--;
            }

            // print the result
            Console.WriteLine("No. of Heads=" + heads);
            Console.WriteLine("No. of tails= " + tails);
        }

        /// <summary>
        /// CountDigit method is used to count the digits in user entered year
        /// </summary>
        /// <param name="year"> this parameter is used to hold the year value</param>
        /// <returns> returns the count of digits in year</returns>
        public int CountDigit(int year)
        {
            int count = 0;

            // repeate the loop for each digit the year
            while (year > 0)
            {
                year = year / 10;
                count++;
            }

            return count;
        }
        
        /// <summary>
        /// IsLeap method is used to check Year is Leap year or Not
        /// </summary>
        /// <param name="year"> year parameter holds the user entered number</param>
        /// <returns> returns true if year is leap otherwise return false</returns>
        public bool IsLeap(int year)
        {
            if (year % 400 == 0 || year % 4 == 0 || year % 100 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// this method is used to calculate the power of two of given number.
        /// </summary>
        /// <param name="number">The number.</param>
        public void CalPowerOfTwo(int number)
        {
            // power variable is used to hold the power value of number
            int power = 1;

            // Check Number is Between 0 to 31
            if (number >= 0 && number < 31)                   
            {
                // repeat the loop from 0 to user entered number
                for (int i = 0; i <= number; i++)
                {
                    // calculate the power of two for i'th number
                    Console.WriteLine("2^ " + i + " = " + power);
                    power = power * 2;
                }
            }
            else
            {
                Console.WriteLine("Enter Number between 0-31 ");
            }
        }

        /// <summary>
        /// CalHarmonicValue method is used to Calculate Harmonic Value of given Number
        /// </summary>
        /// <param name="number"> this parameter holds the user entered number </param>
        /// <returns> returns the harmonic value of given number</returns>
        public float CalHarmonicValue(int number)
        {
            // harmonicValue variable is used to hold the harmonic Value of number
            float harmonicValue = 0;
          
            // check whether user entered number is zero or not
            if (number != 0)
            {
                // repeates the loop from 1 to user entered number to calculate harmonic value
                for (int i = 1; i <= number; i++)
                {
                    // calculate harmonic number 
                    harmonicValue += (float)1 / i;
                }              
            }
            else
            {
                Console.WriteLine("Please Enter Correct Number");
            }

            return harmonicValue;
        }

        /// <summary>
        /// CalPrimeFactors method is used to Find Prime Factors of Given Number
        /// </summary>
        /// <param name="number"> this parameter holds the user entered number</param>
        public void CalPrimeFactors(int number)
        {
            int temp = number;

            // flag is used to indicate whether the user entred number has prime factors or not
            bool flag = false;

            // iterates the loop to check prime factors
            for (int i = 2; i * i <= temp; i++)
            {
                // check whether i'th number is prime factor of given number
                if (temp % i == 0)
                {
                    // if prime factor for given number is found then make flag true
                    flag = true;
                    Console.Write(" " + i);
                    temp = temp / 10;
                }
            }

            // check flag value if it holds false that means prime factors for given number is not found 
            if (flag == false)
            {
                Console.WriteLine("No Prime Factors for given number");
            }
        }
    }
}
