// ******************************************************************************
//  <copyright file="DeckOfcards.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  DeckOfcards.cs
//  
//     Purpose:  Implement program to print Deck of cards
//     @author  Pranali Patil
//     @version 1.0
//     @since   6-12-2019
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
    /// this class contains method to print deck of cards received by players
    /// </summary>
    public class DeckOfcards
    {
        /// <summary>
        /// The cards utility class object to access methods from that class
        /// </summary>
        DeckOfCardsUtility cardsUtility = new DeckOfCardsUtility();

        /// <summary>
        /// Plays the card game.
        /// </summary>
        public void PlayCardGame()
        {
            // geting the all cards to play Deck of card game
            string[] totalCards = cardsUtility.GetCards();

            // shuffle the cards 
            totalCards = cardsUtility.ShuffleCards(totalCards);

            // distribute the cards to 4 players
            string[,] cardsForPlayer = cardsUtility.DistrubuteCards(totalCards);

            // printing the cards received by players
            cardsUtility.showCards(cardsForPlayer);
        }
    }
}
