// ******************************************************************************
//  <copyright file="TransactionData.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  TransactionData.cs
//  
//     Purpose:  Get and set values for json transaction file objects
//     @author  Pranali Patil
//     @version 1.0
//     @since   27-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contains all data objects for transaction info
    /// </summary>
    public class TransactionData
    {
        /// <summary>
        /// Gets or sets the transaction list.
        /// </summary>
        /// <value>
        /// The transaction list.
        /// </value>
        public List<Transaction> TransactionList { get; set; }

        /// <summary>
        /// class contains all object which holds the data of transaction
        /// </summary>
        public class Transaction
        {
            /// <summary>
            /// The date time
            /// </summary>
            private string dateTime;

            /// <summary>
            /// The company name
            /// </summary>
            private string companyName;

            /// <summary>
            /// The company symbol
            /// </summary>
            private string companySymbol;

            /// <summary>
            /// The customer name
            /// </summary>
            private string customerName;

            /// <summary>
            /// The transaction time
            /// </summary>
            private string transactionTime;

            /// <summary>
            /// The transaction date
            /// </summary>
            private string transactionDate;

            /// <summary>
            /// Gets or sets the date time.
            /// </summary>
            /// <value>
            /// The date time.
            /// </value>
            public string Date { get => this.transactionDate; set => this.transactionDate = value; }

            /// <summary>
            /// Gets or sets the date time.
            /// </summary>
            /// <value>
            /// The date time.
            /// </value>
            public string DateTime { get => this.dateTime; set => this.dateTime = value; }

            /// <summary>
            /// Gets or sets the name of the customer.
            /// </summary>
            /// <value>
            /// The name of the customer.
            /// </value>
            public string CustomerName { get => this.customerName; set => this.customerName = value; }

            /// <summary>
            /// Gets or sets the name of the company.
            /// </summary>
            /// <value>
            /// The name of the company.
            /// </value> 
            public string CompanyName { get => this.companyName; set => this.companyName = value; }

            /// <summary>
            /// Gets or sets the company symbol.
            /// </summary>
            /// <value>
            /// The company symbol.
            /// </value>
            public string CompanySymbol { get => this.companySymbol; set => this.companySymbol = value; }

            /// <summary>
            /// Gets or sets the name of the transaction.
            /// </summary>
            /// <value>
            /// The name of the transaction.
            /// </value>
            public string TransactionName { get => this.transactionTime; set => this.transactionTime = value; }
        }
    }
}
