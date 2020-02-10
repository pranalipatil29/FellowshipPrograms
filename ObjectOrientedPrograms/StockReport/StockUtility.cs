// ******************************************************************************
//  <copyright file="StockUtility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  StockUtility.cs
//  
//     Purpose: contains all methods for performning operation for generating Stock Report
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
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// this class contains methods to perform different operation
    /// </summary>
    public class StockUtility
    {           
        /// <summary>
        /// creating list which is used to store data from file.
        /// </summary>
        private static List<StockData> newStock = new List<StockData>();

        /// <summary>
        /// storing file path in file variable   
        /// </summary>
        private static string jsonfilepath = @"C:\Users\User\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\StockReport\StockInfo.json";

        /// <summary>
        /// this method is used to Get the person information.
        /// </summary>
        public void GetPersonInfo()
        {
            // reading stock information 
            Console.WriteLine("Enter Stock Name: ");
            string newStockName = Convert.ToString(Console.ReadLine());

            // check whether the stock entry is already exist in stock file
            StockData result = this.Find(newStockName);

            // if result holds null value that means the Stock entry is not exist in Stock report
            if (result != null)
            {
                // if the stock name is already exist then return to menu
                throw new Exception("\n Stock entry is Already Exist..!\n");
            }
            else
            {
                // if result holds null value that means the stock entry is not exist
                Console.WriteLine("Enter Stock Price : ");
                string newStockPrice = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Number of Share : ");
                string newNumberOfShare = Convert.ToString(Console.ReadLine());

                // passing the person information to AddInStockList method
                 this.AddInStockList(newStockName, newStockPrice, newNumberOfShare);
            }
        }

        /// <summary>
        /// AddInStockList method is used to add the person entry into address book.
        /// </summary>
        /// <param name="newStockName">newStockName parameter holds stock Name.</param>
        /// <param name="newStockPrice">newStockPrice parameter holds stock price.</param>
        /// <param name="newNumberOfShare">newNumberOfShare parameter holds number of share.</param>
        public void AddInStockList(string newStockName, string newStockPrice, string newNumberOfShare)
        {
            // assigning all user entered values to StockData class object
            StockData stockInfoObj = new StockData()
            {
                StockName = newStockName,
                SharePrice = newStockPrice,
                NumberOfShare = newNumberOfShare
            };

            // creating StreamReader class object to read data from json file
            StreamReader streamReader = new StreamReader(jsonfilepath);

            // storing data from json file into jsonfiledata variable
            string jsonfiledata = streamReader.ReadToEnd();

            // converting json file data into json object
            newStock = JsonConvert.DeserializeObject<List<StockData>>(jsonfiledata);

            // adding person information into list
            newStock.Add(stockInfoObj);

            // converting jsonobject data into string
            var convertedJson = JsonConvert.SerializeObject(newStock);

            // closing the streamReader class object
            streamReader.Close();

            // writing all updated data into json file
            File.WriteAllText(jsonfilepath, convertedJson);

            Console.WriteLine("\nEntry Added Successfully into Address Book");
        }

        /// <summary>
        /// Find method is used to finds the user entered Stock name from file.
        /// </summary>
        /// <param name="nametofind">parameter holds the name tobe find.</param>
        /// <returns>this method returns the list contains person info if user entered name was found</returns>
        public StockData Find(string nametofind)
        {
            // creating StreamReader class object to read data from json file
            StreamReader streamReader = new StreamReader(jsonfilepath);

            // storing data from json file into jsonfiledata variable
            string jsonfiledata = streamReader.ReadToEnd();

            // converting json file data into json object
            newStock = JsonConvert.DeserializeObject<List<StockData>>(jsonfiledata);

            // creating StockData class object to store result 
            StockData result = null;

            // iterate loop for each stock entry
            foreach (var entry in newStock)
            {
                // check whether the user entered name is equals to name in stockInfo file
                if (nametofind.Equals(entry.StockName))
                {
                    // if name was found then close the streamreader class object
                    streamReader.Close();

                    // return the Stock entry in stock file indicating the stock name is already exist
                    return entry;
                }
            }

            // if name was not found then close the streamreader class object 
            streamReader.Close();

            // return the result object indicating the stock name is not exist in address book
            return result;
        }

        /// <summary>
        /// this method is used to displays the Stock entries.
        /// </summary>
        public void DisplayStockEntry()
        {
            // creating StreamReader class object to read data from json file
            StreamReader streamReader = new StreamReader(jsonfilepath);

            // storing data from json file into jsonfiledata variable
            string jsonfiledata = streamReader.ReadToEnd();

            // converting json file data into json object
            newStock = JsonConvert.DeserializeObject<List<StockData>>(jsonfiledata);

            Console.WriteLine("\n ----------Stock Report-------------\n");
          
            // iterate loop for each object in json file
            foreach (var entry in newStock)
            {
                // calculating stock value for each stock
                string totalvalueofstock = this.CalculateTotalStackValue(entry.SharePrice, entry.NumberOfShare);

                entry.TotalValue = Convert.ToString(totalvalueofstock);
                
                // priniting data from json file
                Console.Write("\nStock Name: " + entry.StockName + "\nShare Price : " + entry.SharePrice + "\nNumber of Shares : " + entry.NumberOfShare + "\nTotal Value of stock= " + totalvalueofstock + "\n\n");
            }

            // converting jsonobject data into string
            var convertedJson = JsonConvert.SerializeObject(newStock);

            // closing the streamReader class object
            streamReader.Close();

            // writing all updated data into json file
            File.WriteAllText(jsonfilepath, convertedJson);
            streamReader.Close();
            Console.WriteLine("\n-------------------------------\n");
        }

        /// <summary>
        /// this method is used to calculate the total stack value.
        /// </summary>
        /// <param name="sharePrice">This parameter holds share price.</param>
        /// <param name="numberOfShare">This parameter holds number of shares.</param>
        /// <returns> return total value o stack</returns>
        public string CalculateTotalStackValue(string sharePrice, string numberOfShare)
        {
            // converting string value of share price into double
            double price = Convert.ToDouble(sharePrice);

            // converting string value of number of share into double
            double countofshares = Convert.ToDouble(numberOfShare);
        
            // calculating total value of stock
            double totalValue = price * countofshares;

            // returning total value of stock
            return totalValue.ToString();
        }
    }
}
