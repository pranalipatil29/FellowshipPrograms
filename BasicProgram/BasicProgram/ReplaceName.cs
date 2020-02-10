// ******************************************************************************
//  <copyright file="ReplaceName.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  ReplaceName.cs
//  
//     Purpose:  Take user Input and Replace String Template “Hello <<UserName>>, How are you?” 
//     @author  Pranali Patil
//     @version 1.0
//     @since  07-11-2019
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
    /// this class contains methods to replace string 
    /// </summary>
    public class ReplaceName
    {
        /// <summary>
        /// this method is used tor replaces the name of the user.
        /// </summary>
        public void ReplaceUserName()
        {
            // creating utility class object to access methods from that class
            Utility utility = new Utility();

            // userName variable stores user name entered by user 
            string userName;
 
            Console.WriteLine("Enter Your Name: ");
            userName = Convert.ToString(Console.ReadLine());

            // check whether user entered name is less than 3 characters or not
            bool result = utility.CheckLength(userName);           
            if (result)                                             
            {
                // if user entered name length is >= 3 then replace name
                string message = utility.RplaceName(userName);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Enter Valid Name.");
            }
        }
    }
}
