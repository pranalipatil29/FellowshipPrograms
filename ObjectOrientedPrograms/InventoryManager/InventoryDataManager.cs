// ******************************************************************************
//  <copyright file="InventoryDataManager.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  InventoryDataManager.cs
//  
//     Purpose:  this class is used to get and set values for json file objects
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
    using System.Text;

    /// <summary>
    /// this class contains different variables for inventory system
    /// </summary>
    public class InventoryDataManager
    {
        /// <summary>
        /// Gets or sets the rice list.
        /// </summary>
        /// <value>
        /// The rice list.
        /// </value>
        public List<Rice> RiceList { get; set; }

        /// <summary>
        /// Gets or sets the pulses list.
        /// </summary>
        /// <value>
        /// The pulses list.
        /// </value>
        public List<Pulses> PulsesList { get; set; }

        /// <summary>
        /// Gets or sets the wheats list.
        /// </summary>
        /// <value>
        /// The wheats list.
        /// </value>
        public List<Wheats> WheatsList { get; set; }

        /// <summary>
        /// this class contains properties of rice inventory
        /// </summary>
        public class Rice
        {
            /// <summary>
            /// The name
            /// </summary>
            private string name;

            /// <summary>
            /// The weights
            /// </summary>
            private string weights;

            /// <summary>
            /// The price
            /// </summary>
            private string price;

            /// <summary>
            /// The value
            /// </summary>
            private string value;

            /// <summary>
            /// The total value
            /// </summary>
            private string totalValue;

            /// <summary>
            /// Gets or sets the name of rice.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get => this.name; set => this.name = value; }

            /// <summary>
            /// Gets or sets value for the rice the weights.
            /// </summary>
            /// <value>
            /// The weights.
            /// </value>
            public string Weights { get => this.weights; set => this.weights = value; }

            /// <summary>
            /// Gets or sets price of the rice.
            /// </summary>
            /// <value>
            /// The price.
            /// </value>
            public string Price { get => this.price; set => this.price = value; }

            /// <summary>
            /// Gets or sets value for the rice total value.
            /// </summary>
            /// <value>
            /// The value.
            /// </value>
            public string Value { get => this.value; set => this.value = value; }

            /// <summary>
            /// Gets or sets the inventory rice price.
            /// </summary>
            /// <value>
            /// The inventory rice price.
            /// </value>
            public string InventoryRicePrice { get => this.totalValue; set => this.totalValue = value; }
        }

        /// <summary>
        /// this class contains properties of pulses inventory
        /// </summary>
        public class Pulses
        {
            /// <summary>
            /// The name
            /// </summary>
            private string name;

            /// <summary>
            /// The weights
            /// </summary>
            private string weights;

            /// <summary>
            /// The price
            /// </summary>
            private string price;

            /// <summary>
            /// The value
            /// </summary>
            private string value;

            /// <summary>
            /// The total value
            /// </summary>
            private string totalValue;

            /// <summary>
            /// Gets or sets the name of pulses.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get => this.name; set => this.name = value; }

            /// <summary>
            /// Gets or sets the weights of pulses.
            /// </summary>
            /// <value>
            /// The weights.
            /// </value>
            public string Weights { get => this.weights; set => this.weights = value; }

            /// <summary>
            /// Gets or sets the price of pulses.
            /// </summary>
            /// <value>
            /// The price.
            /// </value>
            public string Price { get => this.price; set => this.price = value; }

            /// <summary>
            /// Gets or sets the value of pulses.
            /// </summary>
            /// <value>
            /// The value.
            /// </value>
            public string Value { get => this.value; set => this.value = value; }

            /// <summary>
            /// Gets or sets the inventory pulses price.
            /// </summary>
            /// <value>
            /// The inventory pulses price.
            /// </value>
            public string InventoryPulsesPrice { get => this.totalValue; set => this.totalValue = value; }
        }

        /// <summary>
        /// this class contains properties for Wheats inventory
        /// </summary>
        public class Wheats
        {
            /// <summary>
            /// The name
            /// </summary>
            private string name;

            /// <summary>
            /// The weights
            /// </summary>
            private string weights;

            /// <summary>
            /// The price
            /// </summary>
            private string price;

            /// <summary>
            /// The value
            /// </summary>
            private string value;

            /// <summary>
            /// The total value
            /// </summary>
            private string totalValue;

            /// <summary>
            /// Gets or sets the name of wheats.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get => this.name; set => this.name = value; }

            /// <summary>
            /// Gets or sets the weights of wheats.
            /// </summary>
            /// <value>
            /// The weights.
            /// </value>
            public string Weights { get => this.weights; set => this.weights = value; }

            /// <summary>
            /// Gets or sets the price of wheats.
            /// </summary>
            /// <value>
            /// The price.
            /// </value>
            public string Price { get => this.price; set => this.price = value; }

            /// <summary>
            /// Gets or sets the value of wheats.
            /// </summary>
            /// <value>
            /// The value.
            /// </value>
            public string Value { get => this.value; set => this.value = value; }

            /// <summary>
            /// Gets or sets the inventory wheats price.
            /// </summary>
            /// <value>
            /// The inventory wheats price.
            /// </value>
            public string InventoryWheatsPrice { get => this.totalValue; set => this.totalValue = value; }
        }
    }
}