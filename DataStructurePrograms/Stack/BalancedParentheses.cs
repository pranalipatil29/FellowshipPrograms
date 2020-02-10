// ******************************************************************************
//  <copyright file="BalancedParentheses.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  BalancedParentheses.cs
//  
//     Purpose:  BalancedParentheses takes airthmatic expression from user 
//               and checks whether that expression is balanced or not
//
//     @author  Pranali Patil
//     @version 1.0
//     @since   15-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DataStructurePrograms.Stack
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BalancedParentheses class contains methods to check expression is balanced or not
    /// </summary>
    public class BalancedParentheses
    {
        /// <summary>
        /// this method takes arithmetic expression from user
        /// checks that expression is balanced or not and print the result
        /// </summary>
        /// <exception cref="Exception">returns the run time exceptions</exception>
        public void PrintisExpressionBalanced()
        {
            // creating stackuUility object to access methods from StackuUility class
            StackUtility stackuUility = new StackUtility();
            try
            {
                // expression variable stores user entered airthmatic expression
                string experssion;
              
                // taking airthmatic expression from user
                Console.WriteLine("Enter arithmatic expression : ");
                experssion = Convert.ToString(Console.ReadLine());

                if (experssion.Equals(" "))
                {
                    Console.WriteLine("Please enter correct arithmatic expression");
                }
                else
                {
                    // checks whether user entered expression is balanced or not and stores result in result variable
                    bool result = stackuUility.IsExpressionIsBalanced(experssion);
                    
                    // if result variable indicates true value then user entered expression is balanced
                    if (result)
                    {
                        Console.WriteLine("Given arithmatic Expression is balanced");
                    }
                    else
                    {
                        // if result variable indicates false value then user entered expression is not balanced
                        Console.WriteLine("Given Arithmatic expression is not balanced");
                    }                    
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw new Exception(exception.Message);
            }
        }
    }
}
