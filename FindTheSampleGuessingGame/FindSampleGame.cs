
using System;

namespace FindTheSampleGuessingGame
{
    internal class FindSampleGame
    {
        private Analyzer scanAnalyzer;
        private int rows;
        private int columns;
        private bool foundFirstSample = false;
        private bool gameRunning = false;
        private bool horizontalFeedback;

        // Method to start the game with specified grid dimensions and analyzer type
        public void StartGame(int gridRows, int gridColumns, string analyzerType)
        {
            // Set the rows and columns, defaulting to 5 if invalid
            rows = gridRows;
            columns = gridColumns;
            if (rows <= 0 || columns <= 0 || rows > 10 || columns > 10)
            {
                rows = 5;
                columns = 5;
            }

            // Initialize the appropriate analyzer based on the selected type
            switch (analyzerType.ToLower())
            {
                case "fingerprint":
                    scanAnalyzer = new FingerprintAnalyzer(rows, columns);
                    break;
                case "sample":
                    scanAnalyzer = new SampleAnalyzer(rows, columns);
                    break;
                case "hair":
                    scanAnalyzer = new HairAnalyzer(rows, columns);
                    break;
                default:
                    throw new ArgumentException("Invalid analyzer type.");
            }

            foundFirstSample = false;
            gameRunning = true;
        }

        public int GuessCount => scanAnalyzer.guessCount; // Expose the guess count

        public string MakeGuess(int guessRow, int guessColumn)
        {
            //// Ensure the game is running
            //if (!gameRunning)
            //{
            //    return "Make sure to start the game.";
            //}

            //// Validate that the guess is within the grid bounds
            //if (guessRow < 0 || guessRow >= rows || guessColumn < 0 || guessColumn >= columns)
            //{
            //    return "Your guess is out of bounds, try one more time.";
            //}

            //// Evaluate the guess and check if a sample is found
            //if (scanAnalyzer.EvaluateGuess(guessRow, guessColumn))
            //{
            //    foundFirstSample = !foundFirstSample;
            //    if (foundFirstSample)
            //    {
            //        return "One sample found, now get back to work and find the second!";
            //    }
            //    else
            //    {
            //        gameRunning = false;
            //        return "Great work! You've found both samples.";
            //    }
            //}
            //return "Wrong... keep going.";

            // Ensure the game is running
            if (!gameRunning)
            {
                return "Make sure to start the game.";
            }

            // Validate that the guess is within the grid bounds
            if (guessRow < 0 || guessRow >= rows || guessColumn < 0 || guessColumn >= columns)
            {
                return "Your guess is out of bounds, try one more time.";
            }

            // Evaluate the guess
            bool found = scanAnalyzer.EvaluateGuess(guessRow, guessColumn);
            char sampleSymbol = scanAnalyzer is BloodAnalyzer ? 'B' : scanAnalyzer is DNAAnalyzer ? 'D' : 'S'; // Determine symbol

            if (found)
            {
                // Mark the sample found
                scanAnalyzer.grid[guessRow, guessColumn] = sampleSymbol; // Place sample symbol
                gameRunning = false; // Stop the game after finding the first sample
                return "Sample found! Now find the second!";
            }

            // Determine the direction to indicate
            (int sampleRow, int sampleColumn) = scanAnalyzer.GetSampleLocation();
            if (guessRow < sampleRow) scanAnalyzer.grid[guessRow, guessColumn] = 'V'; // Sample is below
            else if (guessRow > sampleRow) scanAnalyzer.grid[guessRow, guessColumn] = '^'; // Sample is above
            else if (guessColumn < sampleColumn) scanAnalyzer.grid[guessRow, guessColumn] = '>'; // Sample is to the right
            else if (guessColumn > sampleColumn) scanAnalyzer.grid[guessRow, guessColumn] = '<'; // Sample is to the left

            return "Wrong... keep going.";
        }

        public int Rows => rows; // Property to get the number of rows
        public int Columns => columns; // Property to get the number of columns

        public char GetCellValue(int row, int column)
        {
            return scanAnalyzer.GetGridValue(row, column); // Implement this method in the analyzer
        }

        // Property to check if the first sample has been found
        public bool FirstSample => foundFirstSample;

        // Property to check if the game is still running
        public bool IsGameRunning => gameRunning;
    }
}
