// ******************************************************************************
//  <copyright file="ManagerUtility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  ManagerUtility.cs
//  
//     Purpose: contains all methods for performning operation for Inventory Factory Management
//     @author  Pranali Patil
//     @version 1.0
//     @since   26-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/

namespace ObjectOrientedPrograms.InventoryManager
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// this class contains different methods to perform operation for inventory
    /// </summary>
    public class ManagerUtility
    {
        /// <summary>
        /// this variable is used to store file path of All Factory data 
        /// </summary>
        private static string jsonfilepath = @"C:\Users\User\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryManager\InventoryFactoryData.json";

        /// <summary>
        /// this variable is used to store file path of Factory data 
        /// </summary>
        private static string jsonFactoryFilePath = @"C:\Users\User\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryDataManagement\InventoryData.json";

        /// <summary>
        /// DisplayInventoryRiceData this method is used to displays the rice data in inventory.
        /// </summary>
        public void DisplayInventoryRiceData()
        {
            // geting factory data from file and convert it in object type
            InventoryDataManagement.InventoryDataManagementData factorydata = JsonConvert.DeserializeObject<InventoryDataManagement.InventoryDataManagementData>(File.ReadAllText(jsonFactoryFilePath));

            // creating object for Rice class
            InventoryDataManager.Rice dataManagerRice = new InventoryDataManager.Rice();

            // totalvalueofrice variable is used to store the total price of Rice inventory
            double totalvalueofrice = 0;

            // this loop iterates for all the objects in RiceList
            foreach (var rice in factorydata.RiceList)
            {
                // storing rice list information in rice list
                dataManagerRice.Name = rice.Name;
                dataManagerRice.Weights = rice.Weights;
                dataManagerRice.Price = rice.Price;
                dataManagerRice.Value = rice.Value;
               
                // calculating total value for rice object
                totalvalueofrice = totalvalueofrice + Convert.ToDouble(rice.Value);

                // printing information of rice object
                Console.WriteLine("\n Rice Name= " + dataManagerRice.Name + "\n Rice Wheight= " + dataManagerRice.Weights + "\n Rice Price= " + dataManagerRice.Price + "\n Rice Value=" + dataManagerRice.Value + "\n");
            }

            // storing total price of rice inventory in rice inventory object
            dataManagerRice.InventoryRicePrice = Convert.ToString(totalvalueofrice);
            Console.WriteLine("\n Rice Inventory price= " + totalvalueofrice);

            // geting data from manager json file
            InventoryDataManager dataIninventory = JsonConvert.DeserializeObject<InventoryDataManager>(File.ReadAllText(jsonfilepath));

            // adding dataManagerRice object in manager json file
            dataIninventory.RiceList.Add(dataManagerRice);

            // writing data in manager json file after converting it to text
            File.WriteAllText(jsonfilepath, JsonConvert.SerializeObject(dataIninventory));
            Console.WriteLine("\n--------------------------------------\n");
        }

        /// <summary>
        /// this method is used to displays the Pulses in inventory.
        /// </summary>
        public void DisplayInventoryPulsesData()
        {
            // geting factory data from file and convert it in object type
            InventoryDataManagement.InventoryDataManagementData factorydata = JsonConvert.DeserializeObject<InventoryDataManagement.InventoryDataManagementData>(File.ReadAllText(jsonFactoryFilePath));

            // creating object for Pulses class
            InventoryDataManager.Pulses dataManagerPulses = new InventoryDataManager.Pulses();

            // totalvalueofpulses variable is used to store the total price of Pulses inventory
            double totalvalueofpulses = 0;

            // this loop iterates for all the objects in Pulses list
            foreach (var pulses in factorydata.PulsesList)
            {
                // storing rice list information in Pulses list
                dataManagerPulses.Name = pulses.Name;
                dataManagerPulses.Weights = pulses.Weights;
                dataManagerPulses.Price = pulses.Price;
                dataManagerPulses.Value = pulses.Value;

                // calculating total value for rice object
                totalvalueofpulses = totalvalueofpulses + Convert.ToDouble(pulses.Value);

                // printing information of pulses object
                Console.WriteLine("\n Pulses Name= " + dataManagerPulses.Name + "\n Pulses Wheight= " + dataManagerPulses.Weights + "\n Pulses Price= " + dataManagerPulses.Price + "\n Pulses Value=" + dataManagerPulses.Value + "\n");
            }

            // storing total price of Pulses inventory in pulses inventory object
            dataManagerPulses.InventoryPulsesPrice = Convert.ToString(totalvalueofpulses);
            Console.WriteLine("\n Pulses Inventory price= " + totalvalueofpulses);

            // geting data from manager json file
            InventoryDataManager dataIninventory = JsonConvert.DeserializeObject<InventoryDataManager>(File.ReadAllText(jsonfilepath));

            // adding dataManagerRice object in manager json file
            dataIninventory.PulsesList.Add(dataManagerPulses);

            // writing data in manager json file after converting it to text
            File.WriteAllText(jsonfilepath, JsonConvert.SerializeObject(dataIninventory));
            Console.WriteLine("\n--------------------------------------\n");
        }

        /// <summary>
        ///  this method is used to displays the Wheats in inventory.
        /// </summary>
        public void DisplayInventoryWheatsData()
        {
            // geting factory data from file and convert it in object type
            InventoryDataManagement.InventoryDataManagementData factorydata = JsonConvert.DeserializeObject<InventoryDataManagement.InventoryDataManagementData>(File.ReadAllText(jsonFactoryFilePath));

            // creating object for Wheats class
            InventoryDataManager.Wheats dataManagerWheats = new InventoryDataManager.Wheats();

            // totalvalueofWheats variable is used to store the total price of Wheats inventory
            double totalvalueofWheats = 0;

            // this loop iterates for all the objects in wheats list
            foreach (var pulses in factorydata.PulsesList)
            {
                // storing rice list information in Wheats list
                dataManagerWheats.Name = pulses.Name;
                dataManagerWheats.Weights = pulses.Weights;
                dataManagerWheats.Price = pulses.Price;
                dataManagerWheats.Value = pulses.Value;

                // calculating total value for Wheats object
                totalvalueofWheats = totalvalueofWheats + Convert.ToDouble(pulses.Value);

                // printing information of Wheats object
                Console.WriteLine("\n Wheats Name= " + dataManagerWheats.Name + "\n Wheats Wheight= " + dataManagerWheats.Weights + "\n Wheats Price= " + dataManagerWheats.Price + "\n Wheats Value=" + dataManagerWheats.Value + "\n");
            }
           
            // storing total price of Pulses inventory in Wheats inventory object
            dataManagerWheats.InventoryWheatsPrice = Convert.ToString(totalvalueofWheats);
            Console.WriteLine("\n Wheats Inventory price= " + totalvalueofWheats);

            // geting data from manager json file
            InventoryDataManager dataIninventory = JsonConvert.DeserializeObject<InventoryDataManager>(File.ReadAllText(jsonfilepath));

            // adding dataManagerRice object in manager json file
            dataIninventory.WheatsList.Add(dataManagerWheats);

            // writing data in manager json file after converting it to text
            File.WriteAllText(jsonfilepath, JsonConvert.SerializeObject(dataIninventory));
            Console.WriteLine("\n--------------------------------------\n");
        }
    }
}
