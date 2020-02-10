// ******************************************************************************
//  <copyright file="ProxyClient.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  ProxyClient.cs
//  
//     Purpose:  Implementing Proxy Client
//     @author  Pranali Patil
//     @version 1.0
//     @since   5-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Structural.Proxy
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class is used to represent proxy client
    /// </summary>
    /// <seealso cref="DesignPattern.Structural.Proxy.IClient" />
    public class ProxyClient : IClient
    {
        /// <summary>
        /// creating reference of real client
        /// </summary>
        private RealClient realClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyClient"/> class.
        /// </summary>
        public ProxyClient()
        {
            Console.WriteLine("Proxy client trying to get access..");
        }

        /// <summary>
        /// Requests this access permission.
        /// </summary>
        public void Request()
        {
            // check whether proxy server gets access permission or not
            if (this.Access())
            {
                this.realClient = new RealClient();
                this.realClient.Request();
            }
        }

        /// <summary>
        /// Accesses this instance.
        /// </summary>
        /// <returns> returns true if get access permission</returns>
        public bool Access()
        {
            Console.WriteLine("Proxy client checking access..");
            return true;
        }
    }
}
