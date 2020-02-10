// ******************************************************************************
//  <copyright file="CustomerData.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  CustomerData.cs
//  
//     Purpose:  Get and set values for json Customer file objects
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
    /// CustomerData class is used to get or set values for customer data objects
    /// </summary>
    public class CustomerData
    {
        /// <summary>
        /// Gets or sets values for customer list objects.
        /// </summary>
        /// <value>
        /// holds value for customer list objects.
        /// </value>
        public List<Customer> CustomerList { get; set; }

        /// <summary>
        /// this class is used to get or set values for customer data
        /// </summary>
        public class Customer
        {
            /// <summary>
            /// The name
            /// </summary>
            private string name;

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
            /// The company name
            /// </summary>
            private string companyName;

            /// <summary>
            /// Gets or sets the name for customer object..
            /// </summary>
            /// <value>
            /// holds the value for customer name.
            /// </value>
            public string Name { get => this.name; set => this.name = value; }

            /// <summary>
            /// Gets or sets the amount for customer object..
            /// </summary>
            /// <value>
            /// holds the value for customer amount.
            /// </value>
            public int Amount { get => this.amount; set => this.amount = value; }

            /// <summary>
            /// Gets or sets the number of share for customer object..
            /// </summary>
            /// <value>
            /// holds the value for customer number of share.
            /// </value>
            public int NumberOfShare { get => this.numberOfshares; set => this.numberOfshares = value; }

            /// <summary>
            /// Gets or sets the name of the company for customer object..
            /// </summary>
            /// <value>
            /// holds the value for customer name of the company.
            /// </value>
            public string CompanyName { get => this.companyName; set => this.companyName = value; }

            /// <summary>
            /// Gets or sets the total value for customer object.
            /// </summary>
            /// <value>
            /// holds the value for customer total value.
            /// </value>
            public long TotalValue { get => this.totalValue; set => this.totalValue = value; }
        }
    }
}
