// ******************************************************************************
//  <copyright file="InventoryDataManagementData.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  InventoryDataManagementData.cs
//  
//     Purpose:  this class is used to get and set values for json file objects
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
    using System.Text;

    /// <summary>
    /// this class contains properties or lists for data in inventory
    /// </summary>
    public class InventoryDataManagementData
    {
        /// <summary>
        /// Gets or sets values for the rice list.
        /// </summary>
        /// <value>
        /// The rice list.
        /// </value>
        public List<Rice> RiceList { get; set; }

        /// <summary>
        /// Gets or sets values for the pulses list.
        /// </summary>
        /// <value>
        /// The pulses list.
        /// </value>
        public List<Pulses> PulsesList { get; set; }

        /// <summary>
        /// Gets or sets values for the wheats list.
        /// </summary>
        /// <value>
        /// The wheats list.
        /// </value>
        public List<Wheats> WheatsList { get; set; }

        /// <summary>
        /// this class contains properties for rice 
        /// </summary>
        public class Rice
        {
            /// <summary>
            /// The name of rice
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
            /// Gets or sets value for the rice name.
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
            /// Gets or sets value for the rice the price.
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
        }

        /// <summary>
        ///  this class contains properties for Pulses 
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
        }

        /// <summary>
        ///  this class contains properties for Wheats 
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
        }
    }  
}