/******************************************************************************
 *  Execution:    ModifyMessage.cs
 *  
 *  Purpose: Customize Message Demonstration using String Function and RegEx
 *
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   12-11-2019
 *
 ******************************************************************************/
/// Including the requried assemblies in to the program
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithmprograms
{
    class ModifyMessage
    {
        /// <summary>
        /// PrintModifiedMessage method takes user information validated it and Prints the modified message.
        /// </summary>
        public void PrintModifiedMessage()
        {
            Utility utility = new Utility();
            try
            {
                String date = "01/01/2016";
                String nm, fullnm, contactNo;
                String msg = "Hello <<name>>, We have your full name as <<full name>> in our system." +
                    " your contact number is 91-xxxxxxxxxx. Please,let us know in case of any clarification. " +
                    "Thank you BridgeLabz "+date+". ";
                //reads the user name,full name,contact number fro user
                Console.WriteLine("Enter Your First Name:");
                nm = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Your Full Name:");
                fullnm = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter your Contact Number:");
                contactNo = Convert.ToString(Console.ReadLine());
                //modify the message accourding to user new information
                utility.ModifyMsg(msg,nm,fullnm,date,contactNo);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter correct values");
            }
        }
    }
}
