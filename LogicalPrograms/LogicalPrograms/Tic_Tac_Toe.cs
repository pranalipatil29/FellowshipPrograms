using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Tic_Tac_Toe
    {
        /// <summary>
        /// StartPlaying method is used to take the board positions from user to play the game and finaly prints the result of game.
        /// </summary>
        public void StartPlaying()
        {
            Utility utility = new Utility();
            Boolean flag = false;
            try
            {
                utility.CreateBoard();
                int comp = 2;
                int x, y;
                string user = "X";
                string computer = "O";
                Console.WriteLine("Do you want to play first?\n if yes enter Y else enter N:");
                string player = Convert.ToString(Console.ReadLine());

                if (player.Equals("y") || player.Equals("Y"))
                {

                    Console.WriteLine("User turn\n Enter Position for x & y: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                    utility.MarkSign(x, y, user);
                    utility.PrintBoard();
                    comp = 0;

                }
                else
                {
                    Console.WriteLine("Computer Turn \n Enter Position for x & y: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                    utility.MarkSign(x, y, computer);
                    utility.PrintBoard();
                    comp = 1;
                }
                while (flag == false)
                {

                    do
                    {
                        if (comp == 1)
                        {
                            try
                            {
                                Console.WriteLine("\n User turn \n Enter Position for x & y: ");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                utility.MarkSign(x, y, user);
                                utility.PrintBoard();
                                comp = 0;
                                flag = true;
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception.Message);
                                flag = false;
                            }
                        }

                        if (comp == 0)
                        {
                            try
                            {
                                Console.WriteLine("\n Computer Turn \n Enter Position for x & y: ");
                                x = Convert.ToInt32(Console.ReadLine());
                                y = Convert.ToInt32(Console.ReadLine());
                                utility.MarkSign(x, y, computer);
                                utility.PrintBoard();
                                comp = 1;
                                flag = true;
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception.Message);
                                flag = false;
                            }
                        }

                        Console.WriteLine("\n------------------------\n");
                        utility.DisplayWinner();
                    }
                    while (Utility.isEmpty);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

