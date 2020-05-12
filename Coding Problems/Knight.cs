using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems
{
    //A knight is placed on a given square on an 8 x 8 chessboard.It is then moved 
    //randomly several times, where each move is a standard knight move.If the knight 
    //jumps off the board at any point, however, it is not allowed to jump back on.
    //After k moves, what is the probability that the knight remains on the board?
    class Knight
    {
        public static void Play()
        {
            //number of moves before falling off the board. Declare initial var
            int k = 0;
            double plays = 1.00000, totalMoves = 0.00000;
            bool died = false;
            bool playAgain = false;
            //given starting point;
            int startPointX = 2;
            int startPointY = 1;
            //grid size
            int gridX, gridY, gridSizeX = 8, gridSizeY = 8;
            //define type of knight moves
            int xMove1 = 3, xMove2 = 1, yMove1 = 3, yMove2 = 1;
            Random random = new Random();
            //adjust for starting point
            gridX = startPointX;
            gridY = startPointY;
            //play moves
            while (died == false || playAgain == false)
            {
                if (gridX <= 0 || gridY <= 0 || gridX > gridSizeX || gridY > gridSizeY)
                {
                    died = true;
                    Console.WriteLine("The knight is off the board in {0} moves", k);
                    Console.WriteLine("Would you like to play again? Y/N");
                    string again = Console.ReadLine();
                    if (again.ToLower() == "n")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        random = new Random();
                        gridX = startPointX;
                        gridY = startPointY;
                        totalMoves += k;
                        k = 0;
                        died = false;
                        plays++;
                    }
                }
                else
                {
                    //declare vars to keep track
                    int move = random.Next(0, 2);
                    int x = random.Next(0, 2);
                    int y = random.Next(0, 2);
                    //play
                    if (move == 1)
                    {
                        if (x == 1)
                        {
                            if (y == 1)
                            {
                                gridX += xMove1;
                                gridY += yMove1;
                            }
                            if (y == 0)
                            {
                                gridX += xMove1;
                                gridY -= yMove1;
                            }
                        }
                        if (x == 0)
                        {
                            if (y == 1)
                            {
                                gridX -= xMove1;
                                gridY += yMove1;
                            }
                            if (y == 0)
                            {
                                gridX -= xMove1;
                                gridY -= yMove1;
                            }
                        }
                    }
                    if (move == 0)
                    {
                        if (x == 1)
                        {
                            if (y == 1)
                            {
                                gridX += xMove2;
                                gridY += yMove2;
                            }
                            if (y == 0)
                            {
                                gridX += xMove2;
                                gridY -= yMove2;
                            }
                        }
                        if (x == 0)
                        {
                            if (y == 1)
                            {
                                gridX -= xMove2;
                                gridY += yMove2;
                            }
                            if (y == 0)
                            {
                                gridX -= xMove2;
                                gridY -= yMove2;
                            }
                        }
                    }
                    k++;
                    //check
                    Console.WriteLine("gridX position = {0} gridY position = {1} k moves = {2}", gridX, gridY, k);
                    Console.WriteLine("move type = {0} x direction = {1} y direction = {2}", move, x, y);
                }
            }
            Console.WriteLine("\nTotal games played: {0}\nTotal moves played: {1}\nProbalility: {2}", plays, totalMoves, (plays / totalMoves));
            Console.ReadKey();
        }
    }
}
