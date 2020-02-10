// ******************************************************************************
//  <copyright file="StockData.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  StockData.cs
//  
//     Purpose:  this class is used to get and set values for json file objects
//     @author  Pranali Patil
//     @version 1.0
//     @since   25-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.StockReport
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class is used to get or set values for variables
    /// </summary>
    public class StockData
    {
        /// <summary>
        /// stockName holds value of stock name
        /// </summary>
        private string stockName;

        /// <summary>
        /// sharePrice holds value of stock price
        /// </summary>
        private string sharePrice;

        /// <summary>
        /// numberOfShare holds value of number of shares
        /// </summary>
        private string numberOfShare;

        /// <summary>
        /// totalValue holds value of stock value
        /// </summary>
        private string totalValue;

        /// <summary>
        /// Gets or sets the name of the stock.
        /// </summary>
        /// <value>
        /// The name of the stock.
        /// </value>
        public string StockName { get => this.stockName; set => this.stockName = value; }

        /// <summary>
        /// Gets or sets the share price  for stock.
        /// </summary>
        /// <value>
        /// The share price.
        /// </value>
        public string SharePrice { get => this.sharePrice; set => this.sharePrice = value; }

        /// <summary>
        /// Gets or sets the number of share  for stock.
        /// </summary>
        /// <value>
        /// The number of share.
        /// </value>
        public string NumberOfShare { get => this.numberOfShare; set => this.numberOfShare = value; }

        /// <summary>
        /// Gets or sets the total value for stock.
        /// </summary>
        /// <value>
        /// The total value of stock.
        /// </value>
        public string TotalValue { get => this.totalValue; set => this.totalValue = value; }
    }
}
