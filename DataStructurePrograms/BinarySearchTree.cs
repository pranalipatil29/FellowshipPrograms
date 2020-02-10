// ******************************************************************************
//  <copyright file="BinarySearchTree.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  BinarySearchTree.cs
//  
//     Purpose:  Program to  find the number of different binary search trees that can
//               be created using user entered Nodes.
//     @author  Pranali Patil
//     @version 1.0
//     @since   21-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DataStructurePrograms
{  
    /// Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BinarySearchTree class contains method to print the total number of ways to create Binary Search Tree
    /// </summary>
    public class BinarySearchTree
    {
        /// <summary>
        /// PrintBinarySearchTree method takes number of nodes from user and prints the total number of ways to create binary search tree.
        /// </summary>
        public void PrintBinarySearchTree()
        {
            // creating Utility class object to access methods from Utility class
            Utility utility = new Utility();

            // numerOfNodes variable is used to store user entered value
            int numerOfNodes;

            // reading user input for Number of nodes
            Console.WriteLine("Enter no:");
            numerOfNodes = Convert.ToInt32(Console.ReadLine());

            // checks whether user entered number is greater than 0 or not
            if (numerOfNodes < 0)
            {
                // if user entered number is -ve then it's not a valid number
                Console.WriteLine("Please enter valid number: ");
            }
            else
            {
                // otherwise find the Number of ways to create Binarysearch Tree
                int noOfwaysforBST = utility.NumberOfwaysforBST(numerOfNodes);

                // print the totla number of ways to create Binarysearch Tree
                Console.WriteLine("Bst in tree= " + noOfwaysforBST);
            }
        }
    }
}
