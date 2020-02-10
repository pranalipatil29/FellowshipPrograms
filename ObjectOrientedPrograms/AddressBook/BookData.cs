// ******************************************************************************
//  <copyright file="BookData.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  BookData.cs
//  
//     Purpose:  this class is used to get and set values for json file objects
//     @author  Pranali Patil
//     @version 1.0
//     @since   22-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.AddressBook
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BookData class is used to get or set the values for file objects
    /// </summary>
    public class BookData
    {
        /// <summary>
        /// used to hold Full name
        /// </summary>
        private string fullName;

        /// <summary>
        /// used to hold address
        /// </summary>
        private string address;

        /// <summary>
        /// used to hold city name
        /// </summary>
        private string city;

        /// <summary>
        /// The state
        /// </summary>
        private string state;

        /// <summary>
        /// used to hold zip code
        /// </summary>
        private string zip;

        /// <summary>
        /// used to hold phone number
        /// </summary>
        private string phone;

        /// <summary>
        /// Gets or sets the  value for FullName.
        /// </summary>
        /// <value>
        /// contains values for full name.
        /// </value>
        public string FullName { get => this.fullName; set => this.fullName = value; }

        /// <summary>
        /// Gets or sets the value for address.
        /// </summary>
        /// <value>
        /// contains value for address.
        /// </value>
        public string Address { get => this.address; set => this.address = value; }

        /// <summary>
        /// Gets or sets the value for city.
        /// </summary>
        /// <value>
        /// contains value for city.
        /// </value>
        public string City { get => this.city; set => this.city = value; }

        /// <summary>
        /// Gets or sets the value for state.
        /// </summary>
        /// <value>
        /// contains value for state.
        /// </value>
        public string State { get => this.state; set => this.state = value; }

        /// <summary>
        /// Gets or sets the value for zip code.
        /// </summary>
        /// <value>
        /// contains the value for zip.
        /// </value>
        public string Zip { get => this.zip; set => this.zip = value; }

        /// <summary>
        /// Gets or sets the value for phone number.
        /// </summary>
        /// <value>
        /// contains value for phone number.
        /// </value>
        public string Phone { get => this.phone; set => this.phone = value; }
    } 
}
