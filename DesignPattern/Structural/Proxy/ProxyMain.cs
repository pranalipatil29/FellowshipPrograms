// ******************************************************************************
//  <copyright file="ProxyMain.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  ProxyMain.cs
//  
//     Purpose: Implementing Proxy Design Pattern
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
    /// Defines the entry point in Proxy Design Pattern
    /// </summary>
    public class ProxyMain
    {
        /// <summary>
        /// Gets the proxy access.
        /// </summary>
        public void GetProxyAccess()
        {
            // creating object of real client
            IClient realClient = new RealClient();
            realClient.Request();

            // creating object of proxy client
            ProxyClient proxyClient = new ProxyClient();
            proxyClient.Request();
        }
    }
}
