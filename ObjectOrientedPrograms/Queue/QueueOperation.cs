// ******************************************************************************
//  <copyright file="QueueOperation.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  QueueOperation.cs
//  
//     Purpose: Print transaction information using queue
//     @author  Pranali Patil
//     @version 1.0
//     @since   5-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.Queue
{
    // Including the requried assemblies in to the program 
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// This class contains methods to print transaction info from queue
    /// </summary>
    public class QueueOperation
    {
        /// <summary>
        ///  storing transaction file path
        /// </summary>
        private static string jsonTransactionFile = @"C:\Users\User\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialDataProcessing\TranstionInfo.json";

        /// <summary>
        /// creating QueueLinkedList class object
        /// </summary>
        private static QueueUsingLinkedList<int> calendarQueue = new QueueUsingLinkedList<int>();

        /// <summary>
        /// creating object of LinkedListUtility class for string type parameter
        /// </summary>
        private readonly QueueUsingLinkedList<string> trancationQueue = new QueueUsingLinkedList<string>();

        /// <summary>
        /// converting transaction file info into object type
        /// </summary>
        private CommercialDataProcessing.TransactionData transactionFileData = JsonConvert.DeserializeObject<CommercialDataProcessing.TransactionData>(File.ReadAllText(jsonTransactionFile));

        /// <summary>
        ///  creating object of transaction class
        /// </summary>
        private CommercialDataProcessing.TransactionData.Transaction transaction = new CommercialDataProcessing.TransactionData.Transaction();

        /// <summary>
        /// creating object for transaction list
        /// </summary>
        private List<CommercialDataProcessing.TransactionData> transactionData = new List<CommercialDataProcessing.TransactionData>();

        /// <summary>
        /// this method is used to get the data from transaction file.
        /// </summary>
        public void GetDataFromTransaction()
        {
            // this loop iterates for all the objects in CompanyList
            foreach (var transactionEntry in this.transactionFileData.TransactionList)
            {
                // passing values to queue
                this.trancationQueue.EnQueue(Convert.ToString(transactionEntry.TransactionName));
                this.trancationQueue.EnQueue(transactionEntry.Date);
                this.trancationQueue.EnQueue(transactionEntry.DateTime);
            }

            // printing queue elements
            Console.WriteLine("Transaction Name \t Transaction Date \t Transaction Time");

            // iterates the loop for all queue elements
            while (this.trancationQueue.QueueCounter != 0)
            {
                Console.Write(this.trancationQueue.DeQueue() + "\t\t\t " + this.trancationQueue.DeQueue() + "\t\t " + this.trancationQueue.DeQueue() + "\n");
            }
        }
    }
}
