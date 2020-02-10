// ******************************************************************************
//  <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Program.cs
//  
//     Purpose:  Performs Operations depending upon user choice.
//     @author  Pranali Patil
//     @version 1.0
//     @since   22-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.DeckOfCards
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contains all the methods to print deck of card game
    /// </summary>
    public class DeckOfCardsUtility
    {
        /// <summary>
        /// contains the values of suits
        /// </summary>
        public string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };

        /// <summary>
        /// contains values for rank
        /// </summary>
        public string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        /// <summary>
        /// total Cards array contain all 52 cards 
        /// </summary>
        public string[] totalCards = new string[52];

        /// <summary>
        /// this method is used to get the all cards
        /// </summary>
        /// <returns> returns the array of all cards</returns>
        public string[] GetCards()
        {
            // k variable is used to indicate position in total cards array
            int k = 0;

            // this lopp itearates for all suits card
            for (int i = 0; i < suits.Length; i++)
            {
                // this loop iterates for all rank card
                for (int j = 0; j < rank.Length; j++)
                {
                    // storing card in total cards array
                    totalCards[k] = suits[i] + " " + rank[j];
                    k++;
                }
            }
        
            return totalCards;
        }

        /// <summary>
        /// this method is used to shuffle the cards
        /// </summary>
        /// <param name="totalCards"></param>
        /// <returns> returns the cards after shuffling</returns>
       public string[] ShuffleCards(string[] totalCards)
        {
            // temp Card variable is used to temp store the card 
            string tempCard;

            // creating object of random class
            Random random = new Random();

            //index variable is used to indicate randomly generated indext position 
            int index = 0;

            // this loop iterates for all the cards
            for(int i=0; i<totalCards.Length;i++)
            {
                // geting index position
                index = random.Next(52);

                // shuffling the cards
                tempCard = totalCards[index];
                totalCards[index] = totalCards[i];
                totalCards[i] = tempCard;
            }
            return totalCards;
        }

        /// <summary>
        /// this method is used to distribute the cards to 4 players
        /// </summary>
        /// <param name="totalCards"></param>
        /// <returns> returns the array containg cards for each player</returns>
        public string[,] DistrubuteCards(string[] totalCards)
        {
            // creating array which is used to hold cards for players
            string[,] cardsForPlayer = new string[4, 9];

            // k variable is used to indicate index position in array 
            int k = 0;

            // loop iteartes for 4 player
            for(int i=0;i<4;i++)
            {
                // this loop iteretes for 9 cards 
                for(int j=0;j<9;j++)
                {
                    // storing cards for i'th player
                    cardsForPlayer[i, j] = totalCards[k];
                    k++;
                }
            }
            return cardsForPlayer;
        }

        /// <summary>
        /// this method is used to print the cards received by 4 players
        /// </summary>
        /// <param name="cardsForPlayer"></param>
        public void showCards(string[,] cardsForPlayer)
        {
            Console.WriteLine("Player     Cards \n");

            // itearates the loop for 4 player
            for(int i=0;i<4;i++)
            {
                Console.Write("Player " + i +" : ");

                // iterates the loop for cards received by i'th player
                for(int j=0;j<9;j++)
                {
                    Console.Write(cardsForPlayer[i, j] + ", ");
                }
                Console.Write("\n");
            }
        }
    }
}