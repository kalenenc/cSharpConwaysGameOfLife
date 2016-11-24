using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9___Conways_Game_of_Life
{
    public class GameOfLife
    {


        public void PrintGrid(int[,] grid)
        {

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(grid[j, i]);
                }

                Console.WriteLine();
            }
        }

        public int[,] randomizedStars(int[,] definedGrid)
        {
            Random rnd = new Random();
            for (int i = 0; i < 25; i++)
            {
                int random1 = rnd.Next(0, 20);
                int random2 = rnd.Next(0, 20);
                definedGrid[random1, random2] = 1;
            }
            return definedGrid;
        }

        public int[,] DesignGrid()
        {
            int[,] newGrid = new int[20, 20];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    newGrid[j, i] = 0;
                }
            }
            return newGrid;
        }
    }

    class Program
    {
        //MAIN PROGRAM

        static void Main(string[] args)
        {
            GameOfLife Game = new GameOfLife(); //Initializes new class under variable Game
            int[,] definedGrid = Game.DesignGrid(); //calling function to define the grid
            int[,] FinalGrid = Game.randomizedStars(definedGrid); //giving grid variable FinalGrid
            Game.PrintGrid(FinalGrid); //Prints the random grid out
           


            //EVERYTHING UNDER THIS LINE OF CODE IS STILL A WORK IN PROGRESS :)

            int[,] NextGenerationGrid = new int[20,20]; //makes a new grid to put the
                                                        // new "generation grid" to

            Console.WriteLine("HI");

            //want to get access to the coordinates inside of FinalGrid
            int count = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if()
                    {

                    }

                    if (FinalGrid[j, i] == 1) { //if the current cell is alive

                        //if (1 < 2 live neighbors) {
                        //if 
                        if (FinalGrid[j -1, i]  == 1)
                        {
                            count++;
                        }

                        if (FinalGrid[j + 1, i] == 1)
                        {
                            count++;
                        }

                        if (FinalGrid[j, i - 1] == 1)
                        {
                            count++;
                        }

                        if (FinalGrid[j, i + 1] == 1)
                        {
                            count++;
                        }

                        if (FinalGrid[j + 1, i + 1] == 1)
                        {
                            count++;
                        }

                        if (FinalGrid[j -1, i + 1] == 1)
                        {
                            count++;
                        }

                        if (FinalGrid[j + 1, i - 1] == 1)
                        {
                            count++;
                        }
                        if (FinalGrid[j - 1, i - 1] == 1)
                        {
                            count++;
                        }


                        //cell(1) == 0 
                        //}

                    }

                }
            }

            Game.PrintGrid(FinalGrid); //Prints the random grid out



            //if (1 < 2 live neighbors) {
            //cell(1) == 0 
            //}

            //if (1 == 2 neighbors || 1 == 3 neighbors) {
            //cell(1) == 1 (cell lives)
            //}

            //if (cell > 3 neighbors) {
            //cell(1) == 0
            //}

            //if(0 > 3 live neighbors) {
            //cell(1) == 0
            //}

            // Any live cell with fewer than two live neighbours dies, as if caused 
            //by under-population.

            //Any live cell with two or three live neighbours lives on to the next 
            //generation.
            //Any live cell with more than three live neighbours dies, as if by over - 
            //population.
            //Any dead cell with exactly three live neighbours becomes a live cell, 
            //as if by reproduction.

            Console.ReadLine();
        }
    }
}
