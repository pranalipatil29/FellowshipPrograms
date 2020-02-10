// ******************************************************************************
//  <copyright file="StackUtility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  StackUtility.cs
//  
//     Purpose: StackUtility class contains different methods to perform different operations.
//
//     @author  Pranali Patil
//     @version 1.0
//     @since   15-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace DataStructurePrograms.Stack
{ 
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StackUtility class contains all the methods to perform operation on stack using linked list.
    /// </summary>
    public class StackUtility
    {   
        /// <summary>
        /// The top variable is used to indicate top node in linked list    
        /// </summary>
        public static Node top = null;

        /// <summary>
        /// push method is used to push the specified expression character in stack linked lists.
        /// </summary>
        /// <param name="expressionChar">The expressionChar variable contains a character which is needed to push in stack linked list.</param>
        public void Push(char expressionChar)
        {
            // creating a new node to push new character in stack
            Node currentNode = new Node();
           
            // checks whether the stack is full or not if not then add the new node in stack
            if (currentNode == null)
            {
                Console.WriteLine("Stack is Overflow");
                return;
            }
            else
            {
                // pushing character in given expression into stck
                currentNode.data = expressionChar;
                currentNode.next = top;
                top = currentNode;
            }
        }

        /// <summary>
        /// Pop method Pops the character from stack
        /// </summary>
        /// <returns>returns the character from stack</returns>
        public char Pop()
        {
            // checks whether the stack is empty or not
            if (top == null)
            {
                // if stack is empty, there is nothing to return
                Console.WriteLine("Stack is empty");
                return '\0';
            }
            else
            {
                // if stack is not empty then returns the character in stack 
                char popedChar = top.data;
                top = top.next;
               
                // returning the poped character from stack
                return popedChar;
            }
        }

        /// <summary>
        /// isEmpty method is used to checks whether the stack is empty or not 
        /// </summary>
        /// <returns>
        ///   <c>returns true</c> if this instance is empty; otherwise, <c>returns false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            return top == null ? true : false;
        }

        /// <summary>
        /// isExpressionIsBalanced method determines whether is expression is balanced or not
        /// </summary>
        /// <param name="expression">The Arithmetic expression entered by user.</param>
        /// <returns>
        ///   <c>returns true</c> if expression is balanced ; otherwise, returns<c>false</c>.
        /// </returns>
        public bool IsExpressionIsBalanced(string expression)
        {
            // converting given expression into character array
            char[] expressionArray = expression.ToCharArray();
            
            // for loop iterates till it reaches the last character in expressionArray 
            for (int i = 0; i < expressionArray.Length; i++)
            {
                // check if the character in expression array is any type of opening brackets
                if (expressionArray[i] == '{' || expressionArray[i] == '(' || expressionArray[i] == '[')
                {
                    // if any opening brackets appears then push it into stack
                    this.Push(expression[i]);
                }

                // check if the character in expression array is any type of closing brackets
                if (expressionArray[i] == '}' || expressionArray[i] == ')' || expressionArray[i] == ']')
                {
                    // if any closing brackets appears then checks whether the stack is empty or not
                    if (this.IsEmpty())
                    {
                        // if stack is empty then returns false indicating  given Airthmatic expression is not balanced
                        return false;
                    }
                    else if (!this.IsMatchingPair(this.Pop(), expressionArray[i]))
                    {
                        // if both bracktes are not matching then returns false indicating  given Airthmatic expression is not balanced
                        return false;
                    }
                }
            }

            // check is stack is empty or not if empty returns true indicating  given Airthmatic expression is balanced
            if (this.IsEmpty())
            {
                return true;
            }
            else
            {
                // else  returns false indicating  given Airthmatic expression is not balanced
                return false;
            }
        }

        /// <summary>
        /// IsMatchingPair method determines whether character from stack is matching pair for character in expression array.
        /// </summary>
        /// <param name="firstChar">The first character stores the character from stack.</param>
        /// <param name="secondChar">The second character stores character in expression array.</param>
        /// <returns>
        ///   <c>return true</c> if character in stack is matching pair for character in expression array otherwise, returns <c>false</c>.
        /// </returns>
        public bool IsMatchingPair(char firstChar, char secondChar)
        {
            // checks matching pair for character from stack and character in expression Array
            // if both characters hold matching pair brackets then return true otherwise returns false
            if (firstChar == '(' && secondChar == ')')
            {
                return true;
            } 
            else if (firstChar == '{' && secondChar == '}')
            {
                return true;
            }                
            else if (firstChar == '[' && secondChar == ']')
            {
                return true;
            }              
            else
            {
                return false;
            }              
        }

        /// <summary>
        /// creating node
        /// </summary>
        public class Node
        {
            /// <summary>
            /// The data variable is used to indicate the data value for Node 
            /// </summary>
            public char data;

            /// <summary>
            /// The next is used to indicate next node in Linked list
            /// </summary>
            public Node next;

            /// <summary>
            /// Initializes a new instance of the <see cref="Node"/> class.
            /// </summary>
            public Node()
            {
                this.next = null;
            }
        }
    }
}
