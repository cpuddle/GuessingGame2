using System;
using System.Windows.Forms;

namespace FindTheSampleGuessingGame
{
    internal abstract class Analyzer
    {
        protected char[,] grid; // To hold actual evidence
        protected char[,] displayGrid; // To hold what is displayed to the user

        protected Random rand;
        public int guessCount;

        protected Analyzer(int rows, int cols)
        {
            grid = new char[rows, cols];
            displayGrid = new char[rows, cols];

            InitializeGrid();
            rand = new Random();
            guessCount = 0;
        }

        private void InitializeGrid()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = '~'; // Unvisited cell
                    displayGrid[i, j] = '~'; // Initially display nothing
                }
            }
        }

        public abstract void CollectEvidence();

        public char[,] GetGrid() => grid;
        //public char GetGridValue(int row, int column)
        //{
        //    if (row >= 0 && row < grid.GetLength(0) && column >= 0 && column < grid.GetLength(1))
        //    {
        //        return grid[row, column];
        //    }
        //    throw new ArgumentOutOfRangeException("Row or column is out of bounds.");
        //}

        //public virtual bool EvaluateGuess(int guessRow, int guessColumn)
        //{
        //    // Check if the guess matches any of the samples or evidence
        //    if (grid[guessRow, guessColumn] != '~')
        //    {
        //        grid[guessRow, guessColumn] = 'X'; // Mark as found
        //        guessCount++;
        //        return true; // Sample found
        //    }
        //    return false; // Sample not found
        //}

    }

}