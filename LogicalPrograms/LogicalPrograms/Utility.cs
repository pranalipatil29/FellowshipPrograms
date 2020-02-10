/******************************************************************************
  *  Execution:    Utility.cs
 *  
 *  Purpose: contains different methods to perform different operations
 *
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   08-11-2019
 *
 ******************************************************************************/
namespace LogicalPrograms
{

    // Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Utility class contains different methods to perform different types of operations
    /// </summary>
    class Utility
    {
        public const int X = 1, O = -1;
        // public static string player;
        public static string[,] board = new string[3, 3];
        public const string EMPTY = "0";
        public static Boolean isEmpty = true;

        // sattic count variable is used to count how many times random number is generated to generate coupon number
        static int count = 1;

        /// <summary>
        /// CheckgamblerWinOrLoss method is used to check whether user win or loss in gambler game
        /// </summary>
        /// <param name="notimes">notimes variable defines how many time user want to play the game</param>
        /// <param name="stake">stake variable contains money user have</param>
        /// <param name="goal">goal variable contains how much money user wants to wi in game</param>
        public void CheckgamblerWinOrLoss(int notimes, int stake, int goal)
        {
            Random r = new Random();
            int win = 0, loss = 0, bets = 0, cash;
            cash = stake;
            for (int i = 0; i < notimes; i++)
            {
                if (cash >= stake && cash <= goal)
                {
                    bets++;
                    if (r.NextDouble() < 0.5)
                    {
                        cash++;
                        win++;
                    }
                    else
                    {
                        cash--;
                        loss++;
                    }
                }

            }

            Console.WriteLine("\n User wins " + win + " number of times");
            Console.WriteLine("\n User loss " + loss + " no. of times");

        }

        /// <summary>
        /// GenerateCouponNumber method is used to generate N distinct coupon number
        /// </summary>
        /// <param name="arr">arr contains alphabets and numbers to generate coupon number</param>
        /// <param name="n">n defines user entered Distinct number to generate coupon number</param>

        public void GenerateCouponNumber(char[] arr, int n)
        {
            int len = arr.Length;
            Random random = new Random();
        Generat:
            HashSet<string> couponnumer = new HashSet<string>();
            int randomNumber = random.Next();
            int j;
            int i = 1;

            while (randomNumber > 0 && i <= n)
            {
                j = randomNumber % len;
                couponnumer.Add(arr[j].ToString());
                randomNumber = random.Next();
                count++;
                i++;
            }

            // prints generated distinct coupon number if given length match the required length of coupon number
            if (couponnumer.Count == n)
            {
                Console.Write("\ncoupon number=");
                foreach (var k in couponnumer)
                {
                    Console.Write(k);
                }
                Console.WriteLine("\n");
            }
            else
            {
                // if generated coupon number does not match given length of required coupon length again generate coupon number
                goto Generat;
            }

            Console.WriteLine("Total random numbers needed to generate given distinct coupon number= " + count);
        }

        /// <summary>
        /// CalElapsedTime method is used to calculate and print the Elapsed time
        /// </summary>
        /// <param name="old">old variable contains the time when stopwatch started</param>
        /// <param name="newtime">newtime variable contains the time when stopwatch stoped</param>
        public void CalElapsedTime(DateTime old, DateTime newtime)
        {
            TimeSpan e = (newtime.TimeOfDay).Subtract(old.TimeOfDay);
            Console.WriteLine("\nElapsed time = " + e);
        }

        /// <summary>
        /// MarkSign method is used to mark the sign on board at given position
        /// </summary>
        /// <param name="x">x variable contain x point on board</param>
        /// <param name="y">y variable contain y point on board</param>
        public void MarkSign(int x, int y, string player)
        {
            // the board is 3*3 so check whether user entered positions are valid or not 
            if ((x < 0 || x > 2) && (y < 0 || y > 2))
            {
                Console.WriteLine("Invalid Board Position");
            }

            // check whether user entered position is empty or not
            // if user entered position are empty and valid then mark the player sign on given position on board
            if (board[x, y].Equals(EMPTY))
            {
                board[x, y] = player;
                player = player;

            }
            else
            {
                Console.WriteLine("Board Position Already Occupied");
                return;
            }

        }
        /// <summary>
        /// toBoard method is used to Prints board values.
        /// </summary>
        /// <returns></returns>
        public void PrintBoard()
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(board[i, j]);
                    if (j < 3)
                        Console.Write(" | ");
                }
                if (i < 2)
                    Console.WriteLine("\n--------------\n");
            }

        }

        /// <summary>
        /// DisplayWinner method is used to print which player win the game
        /// </summary>
        public void DisplayWinner()
        {
            // check whether X player win if yes then print it and make isEmpty variable false
            if (this.ChackWinner("X"))
            {
                Console.WriteLine("Player X is Winner..!!");
                isEmpty = false;
            }
            else if (this.ChackWinner("O"))
            {
                // otherwise check whether O player win if yes then print it and make isEmpty variable false
                Console.WriteLine("Player O is Winner....!!");
                isEmpty = false;
            }
            else
            {
                // if X and O both player not win then check whether board is empty or still having position to mark the sign
                Boolean flag = false;

                // is board is not empty that means result of game is tie between both players
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if ((board[i, j].Equals("X") || board[i, j].Equals("O")))
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                }
                if (flag)
                {
                    Console.WriteLine("It's Tie..!!!!");
                    isEmpty = false;

                }
            }
        }
        /// <summary>
        /// ChackWinner method Chacks which player win the game.
        /// </summary>
        /// <param name="player">The player variable contain value indicating one of the player.</param>
        /// <returns></returns>
        public Boolean ChackWinner(string player)
        {

            return ((board[0, 0].Equals(player) && board[0, 1].Equals(player) && board[0, 2].Equals(player)) ||
                      (board[1, 0].Equals(player) && board[1, 1].Equals(player) && board[1, 2].Equals(player)) ||
                      (board[2, 0].Equals(player) && board[2, 1].Equals(player) && board[2, 2].Equals(player)) ||
                      (board[0, 0].Equals(player) && board[1, 0].Equals(player) && board[2, 0].Equals(player)) ||
                      (board[0, 1].Equals(player) && board[1, 1].Equals(player) && board[2, 1].Equals(player)) ||
                      (board[0, 2].Equals(player) && board[1, 2].Equals(player) && board[2, 2].Equals(player)) ||
                      (board[0, 0].Equals(player) && board[1, 1].Equals(player) && board[2, 2].Equals(player)) ||
                      (board[0, 2].Equals(player) && board[1, 1].Equals(player) && board[2, 1].Equals(player)));
        }

        public void CreateBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = "0";

                }
            }
        }

    }
}
