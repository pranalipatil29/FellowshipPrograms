// ******************************************************************************
//  <copyright file="CompanyData.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  CompanyData.cs
//  
//     Purpose:  this class is used to get and set values for json company file objects
//     @author  Pranali Patil
//     @version 1.0
//     @since   26-11-2019
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
    /// CompanyData contains all variables or methods for company class
    /// </summary>
    public class CompanyData
    {
        /// <summary>
        /// Gets or sets the company list.
        /// </summary>
        /// <value>
        /// holds values for company data.
        /// </value>
        public List<Company> CompanyList { get; set; }

        /// <summary>
        /// this class is used to takes and assigns values for company data objects
        /// </summary>
        public class Company
        {
            /// <summary>
            /// The company name
            /// </summary>
            private string companyName;

            /// <summary>
            /// The symbol
            /// </summary>
            private string symbol;

            /// <summary>
            /// The number of shares
            /// </summary>
            private int numberOfshares;

            /// <summary>
            /// The amount
            /// </summary>
            private int amount;

            /// <summary>
            /// The total value
            /// </summary>
            private long totalValue;

            /// <summary>
            /// The date time
            /// </summary>
            private string dateTime;

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
            /// Gets or sets the name of the company.
            /// </summary>
            /// <value>
            /// holds the name of the company.
            /// </value>
            public string CompanyName { get => this.companyName; set => this.companyName = value; }

            /// <summary>
            /// Gets or sets the symbol of company.
            /// </summary>
            /// <value>
            /// holds the symbol of company.
            /// </value>
            public string Symbol { get => this.symbol; set => this.symbol = value; }

            /// <summary>
            /// Gets or sets the amount of each share.
            /// </summary>
            /// <value>
            /// holds the amount for each share.
            /// </value>
            public int Amount { get => this.amount; set => this.amount = value; }

            /// <summary>
            /// Gets or sets the number of share for each company.
            /// </summary>
            /// <value>
            /// holds the value of number of share.
            /// </value>
            public int NumberOfShare { get => this.numberOfshares; set => this.numberOfshares = value; }

            /// <summary>
            /// Gets or sets the total value of company.
            /// </summary>
            /// <value>
            /// holds the value of total value of company.
            /// </value>
            public long TotalValue { get => this.totalValue; set => this.totalValue = value; }

            /// <summary>
            /// Gets or sets the time at transaction made.
            /// </summary>
            /// <value>
            /// holds the value for date time.
            /// </value>
            public string DateTime { get => this.dateTime; set => this.dateTime = value; }
        }   
    }
}
