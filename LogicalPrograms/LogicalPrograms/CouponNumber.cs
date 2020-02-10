// ******************************************************************************
//  <copyright file="CouponNumber.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  CouponNumber.cs
//  
//     Purpose: Generate Distinct Coupon Number 
//     @author  Pranali Patil
//     @version 1.0
//     @since    08-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace LogicalPrograms
{
   
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contains methods to generate distinct coupon number
    /// </summary>
    class CouponNumber
    {
        /// <summary>
        /// ProcessdistinctCoupon method takes how many Distinct number user wants on coupon number
        /// and generate the coupon number and Finaly prints how many random number are required to generate given Distinct Coupon number
        /// </summary>
        public void ProcessdistinctCoupon()
        {
            Utility utility = new Utility();
            try
            {
                // numberOfCoupons variable takes distinc number for generating Coupon
                int numberOfCoupons;
                char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

                // reading distinct number from user
                Console.Write("Enter Distinct number to generate coupon : ");
                numberOfCoupons = Convert.ToInt32(Console.ReadLine());

                // generating distinct coupon number
                utility.GenerateCouponNumber(chars, numberOfCoupons);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
