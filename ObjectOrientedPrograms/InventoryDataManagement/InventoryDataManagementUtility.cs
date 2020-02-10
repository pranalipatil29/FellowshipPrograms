// ******************************************************************************
//  <copyright file="InventoryDataManagementUtility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  InventoryDataManagementUtility.cs
//  
//     Purpose: contains all methods for performning operation for Inventory Data Management
//     @author  Pranali Patil
//     @version 1.0
//     @since   25-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.InventoryDataManagement
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// this class contains different methods to perform operation for inventory system
    /// </summary>
    public class InventoryDataManagementUtility
    {
        /// <summary>
        ///  storing file path
        /// </summary>
        private static string jsonfilepath = @"C:\Users\User\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryDataManagement\InventoryData.json";

        /// <summary>
        /// creating regular expression class object
        /// </summary>
        private readonly RegExUtility regExUtility = new RegExUtility();

        /// <summary>
        /// getChoice method is used to Get the user choice for adding information.
        /// </summary>
        public void GetChoice()
        {
            // choice variable is used to store user choice to perform operation
            int choice;

            // flag is used to indicate whether user entered correct choice or not
            bool flag = false;

            // loop iterates untill user enter correct choice
            while (flag == false)
            {
                // perform operations till user wants to exit
                do
                {
                    // takes choice from user
                    Console.WriteLine("\n 1.Add Rice \n 2.Add Pulses \n 3.Add Wheats \n 4.Exit");
                    Console.WriteLine("\n Enter your choice for adding info:");
                    choice = Convert.ToInt32(Console.ReadLine());

                    // Adding information acording to user choice
                    switch (choice)
                    {
                        case 1:
                            // if user wants to add Rice information
                            this.AddRice();

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;
                        case 2:
                            // if user wants to add Pulses information
                            this.AddPulses();

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;
                        case 3:
                            // if user wants to add wheats information
                            this.AddWheats();

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;
                        case 4:
                            // if user wants to exit

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;

                        default:
                            // if user entered wrong value
                            Console.WriteLine("Wrong choice");
                            break;
                    }
                }
                while (choice != 4);
            }
        }

        /// <summary>
        /// AddRice method is used to add new rice type
        /// </summary>
        public void AddRice()
        {
            // creating object for rice class
            InventoryDataManagementData.Rice newdata = new InventoryDataManagementData.Rice();

            // geting values for rice information
            Console.WriteLine("Enter Rice Name: ");
            string riceName = Convert.ToString(Console.ReadLine());
            newdata.Name = riceName;

            // check rice name is valid or not
            if (this.regExUtility.IsCityName(riceName))
            {
                Console.WriteLine("Enter Rice Price: ");
                string ricePrice = Convert.ToString(Console.ReadLine());
                newdata.Price = ricePrice;

                if (this.regExUtility.IsNumber(ricePrice))
                {
                    Console.WriteLine("Enter Rice Weight: ");
                    string riceWeight = Convert.ToString(Console.ReadLine());
                    newdata.Weights = riceWeight;

                    if (this.regExUtility.IsNumber(riceWeight))
                    {
                        // converting json file data to object
                        InventoryDataManagementData data = JsonConvert.DeserializeObject<InventoryDataManagementData>(File.ReadAllText(jsonfilepath));

                        // adding new data in file 
                        data.RiceList.Add(newdata);

                        // writing all data back to json file
                        File.WriteAllText(jsonfilepath, JsonConvert.SerializeObject(data));
                        Console.WriteLine("\n Rice data added in file");
                    }
                    else
                    {
                       throw new Exception("Rice Weight is invalid");
                    }
                }
                else
                {
                    throw new Exception("Rice price is invalid");
                }
            }
            else
            {
                throw new Exception("Rice name is invalid");
            }
        }

        /// <summary>
        /// this method is used to add new Pulses type
        /// </summary>
        public void AddPulses()
        {
            // creating object for Pulses class
            InventoryDataManagementData.Pulses newPulsesdata = new InventoryDataManagementData.Pulses();

            string returnMessage = string.Empty;

            // geting values for pulses information
            Console.WriteLine("Enter Pulse Name: ");
            string pulsesName = Convert.ToString(Console.ReadLine());
            newPulsesdata.Name = pulsesName;
            Console.WriteLine("Enter Pulse Price: ");
            string pulsesPrice = Convert.ToString(Console.ReadLine());
            newPulsesdata.Price = pulsesPrice;
            Console.WriteLine("Enter Pulse Weight: ");
            string pulseWeight = Convert.ToString(Console.ReadLine());
            newPulsesdata.Weights = pulseWeight;

            if (this.regExUtility.IsCityName(pulsesName) && this.regExUtility.IsNumber(pulsesPrice) && this.regExUtility.IsNumber(pulseWeight))
            {
                // converting json file data to object
                InventoryDataManagementData data = JsonConvert.DeserializeObject<InventoryDataManagementData>(File.ReadAllText(jsonfilepath));

                // adding new data in file 
                data.PulsesList.Add(newPulsesdata);

                // writing all data back to json file
                File.WriteAllText(jsonfilepath, JsonConvert.SerializeObject(data));
                Console.WriteLine("\n Pulses data added in file");
            }
            else
            {
              throw new Exception("Invalid data");
            }
        }

        /// <summary>
        /// this method is used to add new Wheats type
        /// </summary>
        public void AddWheats()
        {
            // creating object for Wheats class
            InventoryDataManagementData.Wheats newWheatsdata = new InventoryDataManagementData.Wheats();

            // geting values for Wheats information
            Console.WriteLine("Enter Wheats Name: ");
            string wheatsName = Convert.ToString(Console.ReadLine());
            newWheatsdata.Name = wheatsName;
            Console.WriteLine("Enter Wheats Price: ");
            string wheatsPrice = Convert.ToString(Console.ReadLine());
            newWheatsdata.Price = wheatsPrice;
            Console.WriteLine("Enter Wheats Weight: ");
            string wheatsWeight = Convert.ToString(Console.ReadLine());
            newWheatsdata.Weights = wheatsWeight;

            if (this.regExUtility.IsCityName(wheatsName) && this.regExUtility.IsNumber(wheatsPrice) && this.regExUtility.IsNumber(wheatsWeight))
            {
                // converting json file data to object
                InventoryDataManagementData data = JsonConvert.DeserializeObject<InventoryDataManagementData>(File.ReadAllText(jsonfilepath));

                // adding new data in file 
                data.WheatsList.Add(newWheatsdata);

                // writing all data back to json file
                File.WriteAllText(jsonfilepath, JsonConvert.SerializeObject(data));
                Console.WriteLine("\n Wheats data added in file");
            }
            else
            {
               throw new Exception("Invalid data");
            }
        }

        /// <summary>
        /// this method is used to display all the data from file
        /// </summary>
        public void DisplayInventoryData()
        {
            // creating object for InventoryDataManagementData  class
            InventoryDataManagementData data = JsonConvert.DeserializeObject<InventoryDataManagementData>(File.ReadAllText(jsonfilepath));

            // this loop iterates for all the objects in RiceList
            foreach (var rice in data.RiceList)
            {
                // calculating total value for rice object
                double totalvalueofrice = this.CalculateTotalvalue(rice.Price, rice.Weights);

                rice.Value = Convert.ToString(totalvalueofrice);

                // printing information of rice object
                Console.WriteLine("\n Rice Name= " + rice.Name + "\n Rice Wheight= " + rice.Weights + "\n Rice Price= " + rice.Price + "\n Total value= " + rice.Value + "\n");
            }

            Console.WriteLine("--------------------------------------");

            // this loop iterates for all the objects in PulsesList
            foreach (var pulses in data.PulsesList)
            {
                // calculating total value for Pulses object
                double totalvalueofpulses = this.CalculateTotalvalue(pulses.Price, pulses.Weights);

                pulses.Value = Convert.ToString(totalvalueofpulses);

                // printing information of Pulses object
                Console.WriteLine("\n pulses Name= " + pulses.Name + "\n pulses Wheight= " + pulses.Weights + "\n pulses Price= " + pulses.Price + "\n Total value= " + pulses.Value + "\n");
            }

            Console.WriteLine("--------------------------------------");

            // this loop iterates for all the objects in WheatsList
            foreach (var wheats in data.WheatsList)
            {
                // calculating total value for Wheats object
                double totalvalueofwheats = this.CalculateTotalvalue(wheats.Price, wheats.Weights);

                wheats.Value = Convert.ToString(totalvalueofwheats);

                // printing information of Wheats object
                Console.WriteLine("\n wheats Name= " + wheats.Name + "\n wheats Wheight= " + wheats.Weights + "\n wheats Price= " + wheats.Price + "\n Total value= " + wheats.Value + "\n");
            }

            Console.WriteLine("--------------------------------------");

            File.WriteAllText(jsonfilepath, JsonConvert.SerializeObject(data));
        }

        /// <summary>
        /// this method is used to calculate the total inventory value.
        /// </summary>
        /// <param name="price1">This parameter holds price.</param>
        /// <param name="weight">This parameter holds weight.</param>
        /// <returns>return total value o stack</returns>
        public double CalculateTotalvalue(string price1, string weight)
        {
            // converting string value of share price into double
            double price = Convert.ToDouble(price1);

            // converting string value of number of share into double
            double weights = Convert.ToDouble(weight);

            // calculating total value of stock
            double totalValue = price * weights;

            // returning total value of stock
            return totalValue;
        }
    }
}
