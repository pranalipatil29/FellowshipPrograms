// ******************************************************************************
//  <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Program.cs
//  
//     Purpose:  creating single page application
//     @author  Pranali Patil
//     @version 1.0
//     @since  9 -12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************using System;
namespace EmployeeSPAFrontEnd
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// defines the entry point
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates the web host builder.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns> returns the IWebHostBuilder </returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
