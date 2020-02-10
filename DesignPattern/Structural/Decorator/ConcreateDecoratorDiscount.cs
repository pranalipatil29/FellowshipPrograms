// ******************************************************************************
//  <copyright file="ConcreateDecoratorDiscount.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  ConcreateDecoratorDiscount.cs
//  
//     Purpose:  Implementing Concreate Decorator for adding functionalities to vehicle
//     @author  Pranali Patil
//     @version 1.0
//     @since   4-12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DesignPattern.Structural.Decorator
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  this is Concreate Decorator class
    /// </summary>
    /// <seealso cref="DesignPattern.Structural.Decorator.VehicleDecorator" />
    public class ConcreateDecoratorDiscount : VehicleDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreateDecoratorDiscount"/> class.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        public ConcreateDecoratorDiscount(IVehicle vehicle) : base(vehicle)
        {
        }

        /// <summary>
        /// Gets or sets the discount percentage.
        /// </summary>
        /// <value>
        /// The discount percentage.
        /// </value>
        public int DiscountPercentage { get; set; }

        /// <summary>
        /// Gets the discount.
        /// </summary>
        /// <returns> returns the price of vehicle after calculating discount</returns>
        public override double GetDiscount()
        {
            int percentage = 100 - this.DiscountPercentage;
            return Math.Round((this.GetPrice() * percentage) / 100);
        }
    }
}
