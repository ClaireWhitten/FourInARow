using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] grid =
               {
                    {0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0}
                };

            LoadGrid(grid);



            int column1Teller = 0;
            int column2Teller = 0;
            int column3Teller = 0;
            int column4Teller = 0;
            int column5Teller = 0;
            int column6Teller = 0;
            int column7Teller = 0;
            int playerBeurten = 0;


            bool winner = false;
            bool player1Turn = true;
            string keuze;
            int row = 0;
            int column = 0;

            while (!winner)
            {
                if (player1Turn)
                {
                    Console.Write("\n\nPLAYER 1- Kies een column:");
                    keuze = Console.ReadLine();
                } else
                {
                    Console.Write("\n\nPLAYER 2- Kies een column:");
                    keuze = Console.ReadLine();
                }


                switch (keuze)
                {
                    case "1":
                        if (!columnFull(column1Teller))
                        {
                            row = 5 - column1Teller; //index 5 of first array- at the bottom
                            column = Convert.ToInt32(keuze)-1; //index 0 of nested array
                            if (player1Turn)
                            {
                                grid[row, column] = 1;
                            }
                            else
                            {
                                grid[row, column] = 2;
                            }
                            player1Turn = !player1Turn;
                            column1Teller++;
                            playerBeurten++;
                            LoadGrid(grid);
                        };
                        break;


                    case "2":
                        if (!columnFull(column2Teller))
                        {
                            row = 5 - column2Teller;
                            column = Convert.ToInt32(keuze) - 1;
                            if (player1Turn)
                            {
                                grid[row, column] = 1;
                            }
                            else
                            {
                                grid[row, column] = 2;
                            }
                            player1Turn = !player1Turn;
                            column2Teller++;
                            playerBeurten++;
                            LoadGrid(grid);
                        };
                        break;

                    case "3":
                        if (!columnFull(column3Teller))
                        {
                           row = 5 - column3Teller;
                           column = Convert.ToInt32(keuze) - 1;
                            if (player1Turn)
                            {
                                grid[row, column] = 1;
                            }
                            else
                            {
                                grid[row, column] = 2;
                            }
                            player1Turn = !player1Turn;
                            column3Teller++;
                            playerBeurten++;
                            LoadGrid(grid);
                        };
                        break;

                    case "4":
                        if (!columnFull(column4Teller))
                        {
                            row = 5 - column4Teller;
                            column = Convert.ToInt32(keuze) - 1;
                            if (player1Turn)
                            {
                                grid[row, column] = 1;
                            }
                            else
                            {
                                grid[row, column] = 2;
                            }
                            player1Turn = !player1Turn;
                            column4Teller++;
                            playerBeurten++;
                            LoadGrid(grid);
                        };
                        break;



                    case "5":
                        if (!columnFull(column5Teller))
                        {
                            row = 5 - column5Teller;
                            column = Convert.ToInt32(keuze) - 1;
                            if (player1Turn)
                            {
                                grid[row, column] = 1;
                            }
                            else
                            {
                                grid[row, column] = 2;
                            }
                            player1Turn = !player1Turn;
                            column5Teller++;
                            playerBeurten++;
                            LoadGrid(grid);
                        };
                        break;


                    case "6":
                        if (!columnFull(column6Teller))
                        {
                            row = 5 - column6Teller;
                            column = Convert.ToInt32(keuze) - 1;
                            if (player1Turn)
                            {
                                grid[row, column] = 1;
                            }
                            else
                            {
                                grid[row, column] = 2;
                            }
                            player1Turn = !player1Turn;
                            column6Teller++;
                            playerBeurten++;
                            LoadGrid(grid);
                        };
                        break;


                    case "7":
                        if (!columnFull(column7Teller))
                        {
                            row = 5 - column7Teller;
                            column = Convert.ToInt32(keuze) - 1;
                            if (player1Turn)
                            {
                                grid[row, column] = 1;
                            }
                            else
                            {
                                grid[row, column] = 2;
                            }
                            player1Turn = !player1Turn;
                            column7Teller++;
                            playerBeurten++;
                            LoadGrid(grid);
                        };
                        break;
                    default:
                        Console.WriteLine("Foute input. Druk op 1-7.");
                        break;
                }


                if (playerBeurten >= 4)
                {
                    //check horizontal matches for columns 1-4
                   
                    if (horizontalCheck(row, grid) == 1)
                    {
                        
                        Console.WriteLine("\nPlayer 1 is the winner!");
                        Console.WriteLine("\nGAME OVER!");
                        winner = true;
                    } else if (horizontalCheck(row, grid) == 2)
                    {
                        Console.WriteLine("Player 2 is the winner!");
                        Console.WriteLine("GAME OVER!");
                        winner = true;
                    } 

                  
                  
                    //vertical check method
                    //diagonal check method
                    
                   
                }

               
            }

            Console.WriteLine("\nDo you want to play again?");
            string answer = Console.ReadLine();

        }

        static void LoadGrid(int[,] grid)
        {
            Console.Clear();
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("        " + i + "  ");

            }
            Console.WriteLine("\n");


            for (int i = 0; i < 6; i++)
            {

                for (int j = 0; j < 7; j++)
                {
                    //Console.Write("|    |");
                    Console.Write("     " + "|  ");
                    if (grid[i,j] == 1)
                    {
                       Console.ForegroundColor = ConsoleColor.Blue;
                       Console.Write(grid[i, j]);
                       Console.ForegroundColor = ConsoleColor.White;
                    } else if (grid[i, j] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(grid[i, j]);
                        Console.ForegroundColor = ConsoleColor.White;
                    } 
                   
                    Console.Write("  |");

                }
                if (i != 5)
                {
                    Console.WriteLine("\n");
                }
            }

            for (int i = 0; i < 7; i++)
            {
                if (i == 0)
                {
                    Console.Write("\n     _______");
                }
                else
                {
                    Console.Write("    _______");
                }

            }
        }

        static bool columnFull(int columnteller)
        {
            if (columnteller == 6)
            {
                Console.WriteLine("Je kan deze column niet kiezen. Kies een andere");
                return true;
            }
            else
            {
                return false;
            }
        }


        static int horizontalCheck(int row, int[,] grid) //note: always put a comma for a 2D grid!!!!!!
        {

            for (int i = 0; i <= 3; i++)
            {
                if (grid[row, i] == grid[row, i + 1] && grid[row, i + 1] == grid[row, i + 2] && grid[row, i + 2] == grid[row, i + 3] && grid[row, i] != 0)
                {
                    return grid[row, i]; //return the winning number
                }
                else
                {
                    return 0;
                }
            }
            return 0; //throws error if you don't return something outside for loop
        }


           


    }

}

