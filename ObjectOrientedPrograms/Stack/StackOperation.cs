// ******************************************************************************
//  <copyright file="StackOperation.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  StackOperation.cs
//  
//     Purpose: Perform operations of adding company Symobols in stack using linked list
//     @author  Pranali Patil
//     @version 1.0
//     @since   28-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.Stack
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// this class is used to perform stack operations
    /// </summary>
   public class StackOperation
    {
        /// <summary>
        ///  storing transaction file path
        /// </summary>
        private static string jsonTransactionFile = @"C:\Users\User\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialDataProcessing\TranstionInfo.json";

        /// <summary>
        /// creating stackLinkedList class object
        /// </summary>
        private static StackLinkedList<int> stackObject = new StackLinkedList<int>();

        /// <summary>
        /// creating object of LinkedListUtility class for string type parameter
        /// </summary>
        private readonly StackLinkedList<string> linkedString = new StackLinkedList<string>();

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
                // passing values to stack
                this.linkedString.Push(transactionEntry.CompanySymbol);
                this.linkedString.Push(Convert.ToString(transactionEntry.TransactionName));
            }
        }
    }
}