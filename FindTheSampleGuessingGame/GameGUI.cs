//using System;
//using System.Text;
//using System.Windows.Forms;

//namespace FindTheSampleGuessingGame
//{
//    public partial class GameGUI : Form
//    {
//        private FindSampleGame game;
//        public GameGUI()
//        {
//            InitializeComponent();
//            game = new FindSampleGame(); // Initialize the game object
//        }

//        private void startButton_Click(object sender, EventArgs e)
//        {
//            int rows = int.TryParse(txtRows.Text, out rows) && rows > 0 ? rows : 5;
//            int columns = int.TryParse(txtColumns.Text, out columns) && columns > 0 ? columns : 5;

//            game.StartGame(rows, columns);
//            UpdateGridDisplay();
//            displayMessageLabel.Text = "Game started! Make your guess.";
//        }

//        private void guessButton_Click(object sender, EventArgs e)
//        {
//            if (!game.IsGameRunning)
//            {
//                displayMessageLabel.Text = "Please Start the game.";
//                return;
//            }
//            if (int.TryParse(txtGuessRow.Text, out int guessRow) &&
//                int.TryParse(txtGuessColumn.Text, out int guessColumn) &&
//                guessRow >= 0 && guessRow < game.Rows &&
//                 guessColumn >= 0 && guessColumn < game.Columns)
//            {
//                bool horizontalFeedback = game.GetCurrentFeedback(); // Assume a method to get current feedback mode
//                string resultMessage = game.MakeGuess(guessRow, guessColumn, horizontalFeedback);
//                displayMessageLabel.Text = resultMessage;
//                guessLabel.Text = $"Guesses: {game.GuessCount}";


//                UpdateGridDisplay();
//            }
//            else
//            {
//                displayMessageLabel.Text = "Invalid guess. Please try again.";
//            }
//        }

//        private void UpdateGridDisplay()
//        {
//            StringBuilder gridString = new StringBuilder();

//            for (int row = 0; row < game.Rows; row++)
//            {
//                for (int col = 0; col < game.Columns; col++)
//                {
//                    char cellValue = game.GetCellValue(row, col); // Assuming this method retrieves the grid state
//                    gridString.Append(cellValue + " "); // Append cell value followed by a space
//                }
//                gridString.AppendLine(); // Move to the next line after each row
//            }

//            gridDisplayLabel.Text = gridString.ToString(); // Update the TextBox with the grid string
//        }

//        private void quitButton_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

//        private void restartButton_Click(object sender, EventArgs e)
//        {
//            game = new FindSampleGame(); // Re-initialize the game object
//            txtRows.Clear(); // Clear the row input
//            txtColumns.Clear(); // Clear the column input
//            txtGuessRow.Clear(); // Clear the guess row input
//            txtGuessColumn.Clear(); // Clear the guess column input
//            gridDisplayLabel.Text = ""; // Clear the grid display
//            displayMessageLabel.Text = "Game reset. Enter grid size to start a new game.";
//            guessLabel.Text = "Guess Count: 0";

//        }
//    }
//}

using System;
using System.Text;
using System.Windows.Forms;

namespace FindTheSampleGuessingGame
{
    public partial class GameGUI : Form
    {
        private FindSampleGame game;
        private string analyzerType;


        public GameGUI(string analyzerType)
        {
            InitializeComponent();
            this.analyzerType = analyzerType; // Store the selected analyzer type
            game = new FindSampleGame(); // Initialize the game object

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int rows = int.TryParse(txtRows.Text, out rows) && rows > 0 ? rows : 5;
            int columns = int.TryParse(txtColumns.Text, out columns) && columns > 0 ? columns : 5;

            game.StartGame(rows, columns, analyzerType); // Use the selected analyzer type
            UpdateGridDisplay();
            MessageBox.Show("Game started! Make your guess.");
        }


        private void guessButton_Click(object sender, EventArgs e)
        {
            if (!game.IsGameRunning)
            {
                MessageBox.Show("Please start the game.");
                return;
            }

            if (int.TryParse(txtGuessRow.Text, out int guessRow) &&
                int.TryParse(txtGuessColumn.Text, out int guessColumn) &&
                guessRow >= 0 && guessRow < game.Rows &&
                guessColumn >= 0 && guessColumn < game.Columns)
            {
                string resultMessage = game.MakeGuess(guessRow, guessColumn);
                displayMessageLabel.Text = resultMessage;
                guessLabel.Text = $"Guesses: {game.GuessCount}";

                UpdateGridDisplay();
            }
            else
            {
                MessageBox.Show("Invalid guess. Please try again.");
            }
        }



        private void UpdateGridDisplay()
        {
            StringBuilder gridString = new StringBuilder();

            for (int row = 0; row < game.Rows; row++)
            {
                for (int col = 0; col < game.Columns; col++)
                {
                    char cellValue = game.GetCellValue(row, col); // Retrieve the grid state
                    gridString.Append(cellValue + " "); // Append cell value followed by a space
                }
                gridString.AppendLine(); // Move to the next line after each row
            }

            gridDisplayLabel.Text = gridString.ToString(); // Update the TextBox with the grid string
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            game = new FindSampleGame(); // Re-initialize the game object
            txtRows.Clear(); // Clear the row input
            txtColumns.Clear(); // Clear the column input
            txtGuessRow.Clear(); // Clear the guess row input
            txtGuessColumn.Clear(); // Clear the guess column input
            gridDisplayLabel.Text = ""; // Clear the grid display
            displayMessageLabel.Text = "Game reset. Enter grid size to start a new game.";
            guessLabel.Text = "Guess Count: 0";
        }

    }
}
