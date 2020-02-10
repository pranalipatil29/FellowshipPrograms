// ******************************************************************************
//  <copyright file="CompanySharesOperation.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  CompanySharesOperation.cs
//  
//     Purpose: Perform operations of adding and removing company shares and storing result in linked list
//     @author  Pranali Patil
//     @version 1.0
//     @since   27-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.LinkedList
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// contains method to perform operations of adding and removing company shares and storing result in linked list
    /// </summary>
    public class CompanySharesOperation
    {
        /// <summary>
        /// storing company file path
        /// </summary>
        private static string jsoncompanyfile = @"C:\Users\User\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialDataProcessing\CompanyInfo.json";

        /// <summary>
        /// converting company file info into object type
        /// </summary>
        private CommercialDataProcessing.CompanyData companyFileData = JsonConvert.DeserializeObject<CommercialDataProcessing.CompanyData>(File.ReadAllText(jsoncompanyfile));

        /// <summary>
        /// creating object of company class
        /// </summary>
        private CommercialDataProcessing.CompanyData.Company company = new CommercialDataProcessing.CompanyData.Company();

        /// <summary>
        /// creating object for company list
        /// </summary>
        private List<CommercialDataProcessing.CompanyData> companylist = new List<CommercialDataProcessing.CompanyData>();

        /// <summary>
        /// creating object of LinkedListUtility class for string type parameter
        /// </summary>
        private LinkedListUtility<string> linkedString = new LinkedListUtility<string>();

        /// <summary>
        ///  creating object of LinkedListUtility class for integer type parameter
        /// </summary>
        private LinkedListUtility<int> linkedNumber = new LinkedListUtility<int>();

        /// <summary>
        /// this method is used to store data from company file into linked list.
        /// </summary>
        public void GetDataFromCompany()
        {
            // this loop iterates for all the objects in CompanyList
            foreach (var company in this.companyFileData.CompanyList)
            {
                // passing values to linked list
                this.linkedString.AddDataInLinkedList(company.Symbol);
                this.linkedString.AddDataInLinkedList(Convert.ToString(company.NumberOfShare));
                this.linkedString.AddDataInLinkedList(company.DateTime);
            }
        }

        /// <summary>
        /// this method is used to add the shares in specified company.
        /// </summary>
        public void AddShares()
        {
            // reading company name from user
            Console.WriteLine("Enter Company Name in which you want to add Shares: ");
            string companyName = Convert.ToString(Console.ReadLine());

            // creating object of StockAccountUtility class for accessing methods from that class
            CommercialDataProcessing.StockAccountUtility stockAccountUtility = new CommercialDataProcessing.StockAccountUtility();

            // check whether user entered comapany name is present or not
            string result = stockAccountUtility.Find(companyName);

            // if result variable contains some value that means required company name is found
            if (result != null)
            {
                // if company name found then read number of shares to add
                Console.WriteLine("Enter how many shares you want to add: ");
                int newNumberOfShare = Convert.ToInt32(Console.ReadLine());

                // itreates the loop for every company in system
                foreach (var companyEntry in this.companyFileData.CompanyList)
                {
                    // check whether the required company name is found
                    if (companyEntry.CompanyName.Equals(companyName))
                    {
                        // adds the user enterd shares into company shares
                        companyEntry.NumberOfShare = companyEntry.NumberOfShare + newNumberOfShare;
                        companyEntry.TotalValue = companyEntry.NumberOfShare * companyEntry.Amount;

                        // geting current time of transaction
                        string dateTime = DateTime.Now.ToString();
                        companyEntry.DateTime = dateTime;

                        // converting objects into text and write text data in json company file
                        File.WriteAllText(jsoncompanyfile, JsonConvert.SerializeObject(this.companyFileData));
                        Console.WriteLine("Shares Added..");
                    }
                }
            }
            else
            {
                Console.WriteLine("company not Found");
            }
        }

        /// <summary>
        /// this method is used to delete the shares from specified company.
        /// </summary>
        public void DeleteShares()
        {
            // reading company name from user
            Console.WriteLine("Enter Company Name from which you want to remove Shares: ");
            string companyName = Convert.ToString(Console.ReadLine());

            // creating object of StockAccountUtility class for accessing methods from that class
            CommercialDataProcessing.StockAccountUtility stockAccountUtility = new CommercialDataProcessing.StockAccountUtility();

            // check whether user entered comapany name is present or not
            string result = stockAccountUtility.Find(companyName);

            // if result variable contains some value that means required company name is found
            if (result != null)
            {
                // if company name found then read number of shares to remove
                Console.WriteLine("Enter how many shares you want to remove: ");
                int newNumberOfShare = Convert.ToInt32(Console.ReadLine());

                // itreates the loop for every company in system
                foreach (var companyEntry in this.companyFileData.CompanyList)
                {
                    // check whether the required company name is found
                    if (companyEntry.CompanyName.Equals(companyName))
                    {
                        // check whether the company have that much of shares
                        if (companyEntry.NumberOfShare >= newNumberOfShare)
                        {
                            // remove the user enterd shares into company shares
                            companyEntry.NumberOfShare = companyEntry.NumberOfShare - newNumberOfShare;
                            companyEntry.TotalValue = companyEntry.NumberOfShare * companyEntry.Amount;

                            // geting current time of transaction
                            string dateTime = DateTime.Now.ToString();
                            companyEntry.DateTime = dateTime;

                            // converting objects into text and write text data in json company file
                            File.WriteAllText(jsoncompanyfile, JsonConvert.SerializeObject(this.companyFileData));
                            Console.WriteLine("Shares Removed..");
                        }
                        else
                        {
                            Console.WriteLine("shares not available");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("company not Found");
            }
        }
    }
}
