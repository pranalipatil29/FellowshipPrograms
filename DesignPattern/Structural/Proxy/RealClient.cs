// ******************************************************************************
//  <copyright file="RealClient.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  RealClient.cs
//  
//     Purpose:  Implementing Real Client for proxy design pattern
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
    /// this class is used to represent a real client
    /// </summary>
    /// <seealso cref="DesignPattern.Structural.Proxy.IClient" />
    public class RealClient : IClient
    {
        /// <summary>
        /// Requests this instance.
        /// </summary>
        public void Request()
        {
            Console.WriteLine("Real Client : performing operations \n");
        }
    }
}
