using System;

namespace Sudoku_Solver
{
    public class Program
    {
        public static bool Sudoku(int[,] grid)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j< 9; j++)
                {
                    if (grid[i,j] == 0)
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            if (Valid(grid ,i , j ,k))
                            {
                                grid[i,j] = k;

                                if (Sudoku(grid))
                                {
                                    return true;
                                }
                                grid[i, j] = 0;
                            }
                             
                        }
                        return false;
                    }
                  
                }
            }
            return true;

        }
        public static bool Valid(int[,] grid , int row , int column , int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if(grid[i,column] == num || grid[row , i] == num)
                {
                    return false;
                }
            }

            int newRow = row - row % 3;
            int newColumn = column - column % 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i + newRow , j + newColumn] == num)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void PrintGrid(int[,] grid)
        { 
            for (int i = 0; i < 9; i++)
            {
               
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(grid[i,j]);
                    Console.Write(" ");
                }
            
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] grid = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                string line = Console.ReadLine();
                string[] strings = line.Split(' ');
                for (int j = 0; j < 9; j++)
                {
                    grid[i, j] = Convert.ToInt32(strings[j]);
                }

            }
            //int[,] grid = new int[9, 9]
            //{
            //    {5,3,0,0,7,0,0,0,0},
            //    {6,0,0,1,9,5,0,0,0},
            //    {0,9,8,0,0,0,0,6,0},
            //    {8,0,0,0,6,0,0,0,3},
            //    {4,0,0,8,0,3,0,0,1},
            //    {7,0,0,0,2,0,0,0,6},
            //    {0,6,0,0,0,0,2,8,0},
            //    {0,0,0,4,1,9,0,0,5},
            //    {0,0,0,0,8,0,0,7,9}
            //};
            Console.WriteLine();
            Console.WriteLine("Your Grid Without Sudoku Algorithm \n");
            PrintGrid(grid);
            Console.WriteLine();
            Console.WriteLine("Your Grid After Sudoku Algorithm \n");
            if (Sudoku(grid))
            {
                PrintGrid(grid);
            }
            else
            {
                Console.WriteLine("error");
            }
            
            
        }
    }
}
