// ******************************************************************************
//  <copyright file="StockAccountUtility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  StockAccountUtility.cs
//  
//     Purpose:  Contains all methods to generate Stock Report
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
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// StockAccountUtility class contains all the methods and variables to generate stock report
    /// </summary>
    public class StockAccountUtility
    {
        /// <summary>
        /// Storing customer file path
        /// </summary>
        private static string jsoncustomerfile = @"C:\Users\User\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialDataProcessing\CustomerInfo.json";

        /// <summary>
        ///  storing company file path
        /// </summary>
        private static string jsoncompanyfile = @"C:\Users\User\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialDataProcessing\CompanyInfo.json";

        /// <summary>
        /// storing transaction file path
        /// </summary>
        private static string jsonTranstionFileData = @"C:\Users\User\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialDataProcessing\TranstionInfo.json";

        /// <summary>
        ///  creating Regex utility class object
        /// </summary>
        private readonly RegExUtility regExUtility = new RegExUtility();

        /// <summary>
        /// creating object of Transaction class
        /// </summary>
        private TransactionData.Transaction transaction = new TransactionData.Transaction();

        /// <summary>
        /// creating list object of TransactionData class
        /// </summary>
        private List<TransactionData> transactionList = new List<TransactionData>();

        /// <summary>
        ///  creating object of company class
        /// </summary>
        private CompanyData.Company company = new CompanyData.Company();

        /// <summary>
        ///  creating object for company list
        /// </summary>
        private List<CompanyData> companylist = new List<CompanyData>();

        /// <summary>
        ///  creating object of customer class
        /// </summary>
        private CustomerData.Customer customer = new CustomerData.Customer();

        /// <summary>
        /// this method is used to Create the company account.
        /// </summary>
        public void CreateCompanyAccount()
        {
            // reading Company information 
            Console.WriteLine("Enter Company Name: ");
            string newCompanyName = Convert.ToString(Console.ReadLine());

            // check company name is in correct format
            if (this.regExUtility.IsCityName(newCompanyName))
            {
                // check whether the company is already exist in stock file
                string result = this.Find(newCompanyName);

                // converting json company file data into object type
                CompanyData filedata = JsonConvert.DeserializeObject<CompanyData>(File.ReadAllText(jsoncompanyfile));

                // if result holds null value that means the Company name is not exist in system
                if (result != null)
                {
                    // if the Company name is already exist then return to menu
                    Console.WriteLine("\n Company is Already Exist..!\n");
                }
                else
                {
                    // if result holds null value that means the Company name is not exist in file
                    this.company.CompanyName = newCompanyName;
                    Console.WriteLine("Enter Company Symbol : ");
                    this.company.Symbol = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter amount: ");
                    this.company.Amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number of Share : ");
                    this.company.NumberOfShare = Convert.ToInt32(Console.ReadLine());

                    // calculating total value of shares 
                    double totalvalueOfShare = Convert.ToDouble(this.company.Amount) * Convert.ToDouble(this.company.NumberOfShare);
                    this.company.TotalValue = Convert.ToInt64(totalvalueOfShare);

                    // adding new company object into file data objects
                    filedata.CompanyList.Add(this.company);

                    // converting objects into text and write text data in json file
                    File.WriteAllText(jsoncompanyfile, JsonConvert.SerializeObject(filedata));

                     Console.WriteLine("Company Account is created..!");
                }
            }
            else
            {
                throw new Exception("Company name is invalid");
            }          
        }

        /// <summary>
        /// Finds the specified company name from file.
        /// </summary>
        /// <param name="nameToFind">The name to find.</param>
        /// <returns> returns the message indicating operation is completed or not</returns>
        public string Find(string nameToFind)
        {
            // converting json file data into json object
            CompanyData newCompany = JsonConvert.DeserializeObject<CompanyData>(File.ReadAllText(jsoncompanyfile));

            // creating StockData class object to store result 
            string result = null;

            // creating object of company class
            CompanyData.Company company = new CompanyData.Company();

            // iterate loop for each stock entry
            foreach (var entry in newCompany.CompanyList)
            {
                // check whether the user entered name is equals to name in stockInfo file
                if (nameToFind.Equals(entry.CompanyName))
                {
                    // return the Stock entry in stock file indicating the stock name is already exist
                    return entry.CompanyName;
                }
            }

            // return the result object indicating the stock name is not exist in address book
            return result;
        }

        /// <summary>
        /// this method is used to creates the customer account.
        /// </summary>
        public void CreateCustomerAccount()
        {
            // reading Customer information 
            Console.WriteLine("Enter Customer Name: ");
            string newCustomerName = Convert.ToString(Console.ReadLine());

            if (this.regExUtility.IsFullName(newCustomerName))
            {
                // check whether the Customer is already exist in stock file
                string result = this.FindCustomer(newCustomerName);

                // converting customer file data into objects
                CustomerData filedata = JsonConvert.DeserializeObject<CustomerData>(File.ReadAllText(jsoncustomerfile));

                // if result holds null value that means the Customer name is not exist in Stock report
                if (result != null)
                {
                    // if the Customer name is already exist then return to menu
                   Console.WriteLine("\n Customer is Already Exist..!\n");
                }
                else
                {
                    // if result holds null value that means the Customer name is not exist in file
                    this.customer.Name = newCustomerName;
                    Console.WriteLine("Enter amount: ");
                    this.customer.Amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number of Share : ");
                    this.customer.NumberOfShare = Convert.ToInt32(Console.ReadLine());
                    double totalvalueOfShare = Convert.ToDouble(this.customer.Amount) * Convert.ToDouble(this.customer.NumberOfShare);
                    this.customer.TotalValue = Convert.ToInt64(totalvalueOfShare);

                    // adding new customer object into customer file data object
                    filedata.CustomerList.Add(this.customer);

                    // converting customer file data into text and write it in json customer file
                    File.WriteAllText(jsoncustomerfile, JsonConvert.SerializeObject(filedata));
                    Console.WriteLine("Company Account is created..!");
                }
            }
            else
            {
                throw new Exception("sCustomer name is invalid");
            }
        }

        /// <summary>
        /// Finds the customer name from file.
        /// </summary>
        /// <param name="nameToFind">The name to find.</param>
        /// <returns> returns the string </returns>
        public string FindCustomer(string nameToFind)
        {
            // converting json file data into json object
            CustomerData newcustomer = JsonConvert.DeserializeObject<CustomerData>(File.ReadAllText(jsoncustomerfile));

            // creating CustomerData class object to store result 
            CustomerData.Customer customer = new CustomerData.Customer();

            // result variable is used to hold value tobe returned by FindCustomer method
            string result = null;

            // iterate loop for each Customer entry
            foreach (var entry in newcustomer.CustomerList)
            {
                // check whether the user entered name is equals to name in Customerinfo file
                if (nameToFind.Equals(entry.Name))
                {
                    // return the Customer name in Customerinfo file indicating the Customer name is already exist
                    return entry.Name;
                }
            }

            // return the result object indicating the Customer name is not exist in address book
            return result;
        }

        /// <summary>
        /// this method is used to buy the company shares
        /// </summary>
        public void Buy()
        {
            // reading Customer information 
            Console.WriteLine("Enter Your Name: ");
            string newCustomerName = Convert.ToString(Console.ReadLine());

            // check user given name is valid or not
            if (this.regExUtility.IsFullName(newCustomerName))
            {
                // check whether the Customer is already exist in stock file
                string result = this.FindCustomer(newCustomerName);

                // converting json Customer file data into object
                CustomerData fileData = JsonConvert.DeserializeObject<CustomerData>(File.ReadAllText(jsoncustomerfile));

                // converting json Company file data into object
                CompanyData companyFileData = JsonConvert.DeserializeObject<CompanyData>(File.ReadAllText(jsoncompanyfile));

                // converting json Transaction file data into object
                TransactionData transactionFiledata = JsonConvert.DeserializeObject<TransactionData>(File.ReadAllText(jsonTranstionFileData));

                // if result holds null value that means the Customer name is not exist in system
                if (result != null)
                {
                    // display company info list
                    Console.WriteLine("\n");
                    this.DisplayCompanyData();

                    // reading company name from customer
                    Console.WriteLine("Enter Company name you want to buy its shares: ");
                    string companyName = Convert.ToString(Console.ReadLine());

                    // check whether the user entered company name in exists in system or not
                    result = this.Find(companyName);

                    // if result variable does not holds the null value that means company name is found in system
                    if (result != null)
                    {
                        // reading how many number of shares user wants to buy
                        Console.WriteLine("\n Enter how many shares you want to buy: ");
                        int sharestoBuy = Convert.ToInt32(Console.ReadLine());

                        // iterates loop for companies in company list
                        foreach (var companyentry in companyFileData.CompanyList)
                        {
                            // check whether the company name is same as user entered company name
                            if (companyName.Equals(companyentry.CompanyName))
                            {
                                // iterates loop for customerelist
                                foreach (var customerentry in fileData.CustomerList)
                                {
                                    // find the current customer in customer list
                                    if (newCustomerName.Equals(customerentry.Name))
                                    {
                                        // checks the company has user required number of shares and to buy that shares customer have that much amount
                                        if ((sharestoBuy < companyentry.NumberOfShare) && (customerentry.TotalValue > (companyentry.Amount * sharestoBuy)))
                                        {
                                            // decrement the company shares
                                            companyentry.NumberOfShare = companyentry.NumberOfShare - sharestoBuy;

                                            // calculate the total value for company shares
                                            companyentry.TotalValue = companyentry.NumberOfShare * companyentry.Amount;

                                            // adding the number of shares in customer shares
                                            customerentry.NumberOfShare = customerentry.NumberOfShare + sharestoBuy;

                                            // calculating new total value for customer shares
                                            customerentry.TotalValue = Convert.ToInt64(customerentry.NumberOfShare * customerentry.Amount);
                                            customerentry.CompanyName = companyentry.CompanyName;

                                            // geting currect time
                                            string dateTime1 = DateTime.Now.TimeOfDay.ToString();

                                            string date = DateTime.Now.ToShortDateString();

                                            // storing current time in company object
                                            companyentry.DateTime = dateTime1;
                                            companyentry.Date = date;

                                            // assigning current time,company name and customer name to transaction class object
                                            this.transaction.DateTime = dateTime1;
                                            this.transaction.Date = date;
                                            this.transaction.CompanyName = companyentry.CompanyName;
                                            this.transaction.CustomerName = customerentry.Name;
                                            this.transaction.TransactionName = "Buy";
                                            this.transaction.CompanySymbol = companyentry.Symbol;

                                            // adding transacton info in transaction list
                                            transactionFiledata.TransactionList.Add(this.transaction);

                                            // converting objects into text and write text data in json transaction file
                                            File.WriteAllText(jsonTranstionFileData, JsonConvert.SerializeObject(transactionFiledata));

                                            // converting objects into text and write text data in json customer file
                                            File.WriteAllText(jsoncustomerfile, JsonConvert.SerializeObject(fileData));

                                            // converting objects into text and write text data in json company file
                                            File.WriteAllText(jsoncompanyfile, JsonConvert.SerializeObject(companyFileData));

                                            Console.WriteLine("Successfully buy Shares");
                                        }
                                        else
                                        {
                                          Console.WriteLine("\n Can't buy Shares this time");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Company Name not foun in System");
                    }
                }
                else
                {
                    // if result variable holds the null value that means company name is not found in system
                    throw new Exception("Customer Name Not Exist in system");
                }
            }
            else
            {
                throw new Exception("Invalid name");
            }
        }

        /// <summary>
        /// this method is used to perform Sell operation.
        /// </summary>
        public void Sell()
        {
            // reading Company information 
            Console.WriteLine("Enter Your Name: ");
            string newCompanyName = Convert.ToString(Console.ReadLine());

            // check user given name is valid
            if (this.regExUtility.IsCityName(newCompanyName))
            {
                // check whether the Customer is already exist in stock file
                string result = this.Find(newCompanyName);

                // converting json Customer file data into object
                CustomerData fileData = JsonConvert.DeserializeObject<CustomerData>(File.ReadAllText(jsoncustomerfile));

                // converting json Company file data into object
                CompanyData companyFileData = JsonConvert.DeserializeObject<CompanyData>(File.ReadAllText(jsoncompanyfile));

                // converting json Transaction file data into object
                TransactionData transactionFiledata = JsonConvert.DeserializeObject<TransactionData>(File.ReadAllText(jsonTranstionFileData));

                // if result holds null value that means the company name is not exist in system
                if (result != null)
                {
                    // display customer info list
                    Console.WriteLine("\n");
                    this.DisplayCustomerData();

                    // reading customer name from company 
                    Console.WriteLine("Enter Customer name to sell your shares: ");
                    string customerName = Convert.ToString(Console.ReadLine());

                    // check whether the user entered company name in exists in system or not
                    result = this.FindCustomer(customerName);

                    // if result variable does not holds the null value that means company name is found in system
                    if (result != null)
                    {
                        // reading how many number of shares you wants to sell
                        Console.WriteLine("\n Enter how many shares you want to sell: ");
                        int sharesToSell = Convert.ToInt32(Console.ReadLine());

                        // iterates loop for customerelist
                        foreach (var customerentry in fileData.CustomerList)
                        {
                            // find the customer name is same as user entered customer name
                            if (customerName.Equals(customerentry.Name))
                            {
                                // iterates loop for companies in company list
                                foreach (var companyEntry in companyFileData.CompanyList)
                                {
                                    // find the company name
                                    if (newCompanyName.Equals(companyEntry.CompanyName))
                                    {
                                        // check whether the company have required number of shares and customer have balance to take that much of shares
                                        if ((sharesToSell < companyEntry.NumberOfShare) && (customerentry.TotalValue > (companyEntry.Amount * sharesToSell)))
                                        {
                                            // decrement the company shares
                                            companyEntry.NumberOfShare = companyEntry.NumberOfShare - sharesToSell;

                                            // calculate the total value for company shares
                                            companyEntry.TotalValue = companyEntry.NumberOfShare * companyEntry.Amount;

                                            // adding the number of shares in customer shares
                                            customerentry.NumberOfShare = customerentry.NumberOfShare + sharesToSell;

                                            // calculating total value for customer shares
                                            customerentry.TotalValue = Convert.ToInt64(customerentry.NumberOfShare * customerentry.Amount);
                                            customerentry.CompanyName = companyEntry.CompanyName;

                                            // geting current time and date
                                            string dateTime = DateTime.Now.TimeOfDay.ToString();
                                            string date = DateTime.Now.ToShortDateString();

                                            // assigning current time to company object
                                            companyEntry.DateTime = dateTime;
                                            companyEntry.Date = date;

                                            // assigning current time,company name,customer name and Type of transaction to transaction class object
                                            this.transaction.DateTime = dateTime;
                                            this.transaction.Date = date;
                                            this.transaction.CompanyName = companyEntry.CompanyName;
                                            this.transaction.CustomerName = customerentry.Name;
                                            this.transaction.TransactionName = "Sell";
                                            this.transaction.CompanySymbol = companyEntry.Symbol;

                                            // adding transacton info in transaction list
                                            transactionFiledata.TransactionList.Add(this.transaction);

                                            // converting objects into text and write text data in json transaction file
                                            File.WriteAllText(jsonTranstionFileData, JsonConvert.SerializeObject(transactionFiledata));

                                            // converting objects into text and write text data in json customer file
                                            File.WriteAllText(jsoncustomerfile, JsonConvert.SerializeObject(fileData));

                                            // converting objects into text and write text data in json company file
                                            File.WriteAllText(jsoncompanyfile, JsonConvert.SerializeObject(companyFileData));
                                            Console.WriteLine("Shares selled to Customer");
                                        }
                                        else
                                        {
                                            throw new Exception("Can't sell Shares this time");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // if customer name entered by user not found
                        throw new Exception("Customer name not found in System");
                    }
                }
                else
                {
                    // if user entered company name was not found
                    throw new Exception("Company Name not Found in System");
                }
            }
            else
            {
                throw new Exception("Invali name");
            }
        }

        /// <summary>
        /// PrintStockReport method is used to Print the stock report.
        /// </summary>
        public void PrintStockReport()
        {
            Console.WriteLine("\n---------------------------------------------Stock Market-------------------------------------------\n");
            this.DisplayCompanyData();
            this.DisplayCustomerData();
            this.DisplayTransactionData();
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------\n");
        }

        /// <summary>
        /// this method is used to displays the company data.
        /// </summary>
        public void DisplayCompanyData()
        {
            Console.WriteLine("\n------------------------------------------Company Info-----------------------------------------------");

            // creating object for InventoryDataManagementData  class
            CompanyData data = JsonConvert.DeserializeObject<CompanyData>(File.ReadAllText(jsoncompanyfile));

            Console.WriteLine("\nCompany Name\t Company Symbol\t Company Price\t Company Shares\t Total value\t   Transaction Date & Time\n");

            // this loop iterates for all the objects in CompanyList
            foreach (var company in data.CompanyList)
            {
                // printing information of rice object
                Console.WriteLine("\n" + company.CompanyName + "  \t\t  " + company.Symbol + "\t\t " + company.Amount + "\t\t    " + company.NumberOfShare + "\t\t " + company.TotalValue + "\t\t   " + company.Date + " " + company.DateTime + "\n");
            }

            Console.WriteLine("\n");
        }

        /// <summary>
        /// this method is used to displays the customer data.
        /// </summary>
        public void DisplayCustomerData()
        {
            Console.WriteLine("\n--------------------------------------------Customer Info--------------------------------------------");

            // creating object for InventoryDataManagementData  class
            CustomerData data = JsonConvert.DeserializeObject<CustomerData>(File.ReadAllText(jsoncustomerfile));

            Console.WriteLine("\n Customer Name \t   Share Price \t   Number of shares \t   Total value \t   Company Name: \n");

            // this loop iterates for all the objects in CustomerList
            foreach (var customer in data.CustomerList)
            {
                // printing information of rice object
                Console.WriteLine("\n" + customer.Name + "\t\t " + customer.Amount + "\t\t  " + customer.NumberOfShare + "\t\t   " + customer.TotalValue + "\t\t " + customer.CompanyName + "\n");
            }

            Console.WriteLine("\n");
        }

        /// <summary>
        /// DisplayTransactionData method is used to display transaction info 
        /// </summary>
        public void DisplayTransactionData()
        {
            Console.WriteLine("\n------------------------------------------Transaction Info-------------------------------------------");

            // creating object for InventoryDataManagementData  class
            TransactionData data = JsonConvert.DeserializeObject<TransactionData>(File.ReadAllText(jsonTranstionFileData));

            Console.WriteLine("\nTransaction Type \tCompany Name \t Customer Name  \t   Transaction Date & time");

            // this loop iterates for all the objects in TransactionList
            foreach (var transaction in data.TransactionList)
            {
                // printing information of rice object
                Console.WriteLine("\n" + transaction.TransactionName + "\t\t\t" + transaction.CompanyName + "\t\t " + transaction.CustomerName + "\t\t  " + transaction.Date + " " + transaction.DateTime);
            }

            Console.WriteLine("\n");
        }

        /// <summary>
        /// this method is used to deletes the company.
        /// </summary>
        public void DeleteCompany()
        {
            // take user input for company name
            Console.WriteLine("\nEnter Company Name to delete it: ");
            string companyTodelete = Convert.ToString(Console.ReadLine());

            // check user given name is valid or not
            if (this.regExUtility.IsCityName(companyTodelete))
            {
                // checks whether user entered company is present in system or not
                string result = this.Find(companyTodelete);

                // converting json file data into object type
                CompanyData data = JsonConvert.DeserializeObject<CompanyData>(File.ReadAllText(jsoncompanyfile));

                // check whether result variable holds null value or not
                if (result != null)
                {
                    // iterates loop for companies in system
                    foreach (var entry in data.CompanyList)
                    {
                        // checks whether user entered company name is found or not
                        if (entry.CompanyName.Equals(companyTodelete))
                        {
                            // if user entered name found then remove that company info from system
                            data.CompanyList.Remove(entry);
                            Console.WriteLine("\nCompany is deleted");

                            // converting object type data into text
                            var convertedJson = JsonConvert.SerializeObject(data);

                            // writing updated data in json file
                            File.WriteAllText(jsoncompanyfile, convertedJson);
                            break;
                        }
                    }
                }
                else
                {
                    throw new Exception("Company name not Found in system");
                }
            }
            else
            {
                throw new Exception("Invalid name");
            }
        }

        /// <summary>
        /// this method is used to Deletes the customer.
        /// </summary>
        public void DeleteCustomer()
        {
            // reading name to delete from user
            Console.WriteLine("\nEnter Customer Name to delete it: ");
            string customerTodelete = Convert.ToString(Console.ReadLine());

            if (this.regExUtility.IsFullName(customerTodelete))
            {
                // checks whether that customer is present or not
                string result = this.Find(customerTodelete);

                // converting json file data into object type
                CustomerData customerData = JsonConvert.DeserializeObject<CustomerData>(File.ReadAllText(jsoncustomerfile));

                // flag is used to indicate whether the operation is done or not
                bool flag = false;

                // iterates the loop for customers in system
                foreach (var entry in customerData.CustomerList)
                {
                    // check user entered name for name in system list
                    if (entry.Name.Equals(customerTodelete))
                    {
                        // if user entered name found then delete that customer entry
                        customerData.CustomerList.Remove(entry);
                        Console.WriteLine("\nCustomer is deleted");

                        // converting object data into text
                        var convertedJson = JsonConvert.SerializeObject(customerData);

                        // writing updated data in json file
                        File.WriteAllText(jsoncustomerfile, convertedJson);
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    throw new Exception("Customer name not Found in system");
                }
            }
            else
            {
                throw new Exception("Invalid name");
            }
        }
    }
}