// ******************************************************************************
//  <copyright file="QueueUtility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  QueueUtility.cs
//  
//     Purpose: QueueUtility contaions all the methods to perform operations on queue and operation at Bank cash counter
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
    /// QueueUtility class contains all the methods to perform operations on Queue
    /// </summary>
    public class QueueUtility
    {
        /// <summary>
        /// front ,rear variables are used to indicate the front and rear position in queue
        /// max variable indicates the maximum size of queue    
        /// </summary>
        public int front, rear, max;

        /// <summary>
        /// elementOfQueue array holds elements in queue
        /// </summary>
        public string[] elementOfQueue;

        /// <summary>
        /// bankBalance variable determines money in bank 
        /// </summary>
        public double bankBalance = 100000;

        /// <summary>
        /// bankCashLimit variable determines the bank cash limit
        /// </summary>
        public double bankCashLimit = 1000;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueUtility"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public QueueUtility(int size)
        {
            // creates array of queue size for storing queue elements
            this.elementOfQueue = new string[size];

            // initialize front of queue to 0'th location,rear to -1 and max variable to size of queue
            this.front = 0;
            this.rear = -1;
            this.max = size;
        }

        /// <summary>
        /// this method is used to add the elements in queue.
        /// </summary>
        /// <param name="element">The element variable holds value tobe stored in queue.</param>
        public void EnQue(string element)
        {
            // checks whether the queue is already full or not
            if (this.rear == this.max - 1)
            {
                // if queue is already full then return 
                Console.WriteLine("Queue is Overflow");
                return;
            }
            else
            {
                // if queue is not full then add the element in queue
                this.elementOfQueue[++rear] = element;
            }
        }

        /// <summary>
        /// deQueue method is used to remove the element from queue.
        /// </summary>
        /// <returns>this method returns the removed element from queue </returns>
        public string DeQue()
        {
            // checks whether the queue is empty or not
            if (this.front == this.rear + 1)
            {
                // if front and rear both variable points to same position in queue that means queue is empty
                Console.WriteLine("Queue is Empty");
                return null;
            }
            else
            {
                // if queue is not empty then remove the element from front of the queue
                string p = this.elementOfQueue[this.front++];

                // returns the removed element from queue
                return p;
            }
        }

        /// <summary>
        /// getPeopleInformation method gets the people information and add them in queue.
        /// </summary>
        public void GetPeopleInformation()
        {
            // takes person name
            Console.Write("\nEnter Your Name : ");
            string nameOfPerson = Convert.ToString(Console.ReadLine());

            // adding that person in queue
            this.EnQue(nameOfPerson);
        }

        /// <summary>
        /// Withdraw method is used to perform Withdraw cash operation.
        /// </summary>
        /// <returns>this method returns true or false based on whether the operation of withdrawal of cash </returns>
        public bool Withdraw()
        {
            // takes amount from person for withdraw
            Console.WriteLine("Enter amaount you want to withraw: ");
            double withdrawMoney = Convert.ToDouble(Console.ReadLine());

            // checks whether the person entered amount is correct or not
            if (withdrawMoney <= 0)
            {
                // if person enetered balance is not valid then return false indicating operation was unsuccessfull
                Console.WriteLine("Not Valid Balance...");
                return false;
            }
            else if (withdrawMoney > this.bankBalance)
            {
                // checks whether the person wants amount which is greater than bank cash limit
                Console.WriteLine("Sorry for inconvenience ..Balance not available...");

                // if yes then return false 
                return false;
            }
            else
            {
                // store bank balance in temp variable
                double tempBankBalance = this.bankBalance;
                tempBankBalance -= withdrawMoney;

                // ckeck whether after withdrawing operation makes bank cash less than bank cash limit
                if (tempBankBalance < this.bankCashLimit)
                {
                    Console.WriteLine("Sorry for inconvenience ..Balance not available...");
                    return false;
                }
                else
                {
                    // otherwise perform withdraw operation
                    this.bankBalance -= withdrawMoney;
                    Console.WriteLine("Collect your cash :" + withdrawMoney);
                    Console.WriteLine("Current Bank Balance= " + this.bankBalance);

                    // returns true indicating the operation was successfull
                    return true;
                }
            }
        }

        /// <summary>
        /// Deposit method is used to perform deposit operation at bank cash counter.
        /// </summary>
        /// <returns>this method returns true or false based on whether the operation result</returns>
        public bool Deposit()
        {
            // takes amount from person for deposite
            Console.WriteLine("Enter amaount you want to deposite: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            // checks whether the person entered amount is in valid range
            if (depositAmount <= 0 || depositAmount < 100)
            {
                // if person entered amount is not in valid range then return false indicating operation wa unsuccessfull
                Console.WriteLine("Can't accept amount less than 100 Rs.: ");
                return false;
            }
            else
            {
                // otherwise performs deposite operation
                this.bankBalance += depositAmount;
                Console.WriteLine("Amaount deposited Successfully....");
                Console.WriteLine("Current bank Balance= " + this.bankBalance);

                // return true indicating that operation was successfull
                return true;
            }
        }
    }
}
