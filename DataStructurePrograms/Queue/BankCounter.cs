// ******************************************************************************
//  <copyright file="BankCounter.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  BankCounter.cs
//  
//     Purpose: Creates Banking Cash Counter where people come in to deposit Cash and withdraw Cash
//
//     @author  Pranali Patil
//     @version 1.0
//     @since   19-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/

namespace DataStructurePrograms.Queue
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BankCounter class contains methods which performs different operations 
    /// </summary>
    public class BankCounter
    {
        /// <summary>
        /// CashCounter method adds and removes people from queue and performs Cash withdraw or deposit Operation for each people
        /// </summary>
        public void CashCounter()
        {
            // totalPeople variable contains people count to add them in queue
            int totalPeople = 0;

            // taking count of people to add in queue
            Console.WriteLine("Enter How many people you want to add in queue: ");
            totalPeople = Convert.ToInt32(Console.ReadLine());

            // check whether user enter any -ve number or not
            if (totalPeople < 0)
            {
                // if user entered number is -ve then it's not a valid number
                Console.WriteLine("Please enter valid number: ");
            }
            else
            {
                // creating QueueUtility class object to create queue for totalPeople
                QueueUtility queueUtility = new QueueUtility(totalPeople);

                // for loop iterates for each person in queue 
                for (int i = 0; i < totalPeople; i++)
                {
                    // get the person information in queue
                    queueUtility.GetPeopleInformation();
                }

                // perform operations like cash Withdraw or cash Deposite for each person in queue
                for (int i = 0; i < totalPeople; i++)
                {
                    // get the first person at cash counter from queue
                    string personFromQueue = queueUtility.DeQue();

                    Console.WriteLine("\nPerson at cash Counter is : " + personFromQueue);

                    // flag variable indicates whether user entered choice is correct or not
                    bool flag = false;

                    // repete the loop till user enter correct choice
                    while (flag == false)
                    {
                        // choice variable stores the person choice for performing operations
                        int choice;

                        // repete the operations till user want to exit
                        do
                        {
                            // takes the user choice to perform the operation
                            Console.WriteLine("\n 1.Withdrow \t 2.Deposit \t 3.Exit\n Eneter your choice: ");
                            choice = Convert.ToInt32(Console.ReadLine());

                            // perform operations as per person choice
                            switch (choice)
                            {
                                case 1:
                                    // if user wants to withdraw cash
                                    flag = queueUtility.Withdraw();
                                    break;
                                case 2:
                                    // if user wants to deposite cash
                                    flag = queueUtility.Deposit();
                                    break;
                                case 3:
                                    // if user wants to exit from cash counter
                                    Console.WriteLine(personFromQueue + " Removed From cash Counter");
                                    Console.WriteLine("------------------------Next Person from queue---------------");
                                    flag = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong Choice");
                                    break;
                            }
                        }
                        while (choice != 3);        // repete the loop utill user want to exit from cash counter
                    }
                }
            }
        }
    }
}
