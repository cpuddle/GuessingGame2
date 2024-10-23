namespace FindTheSampleGuessingGame
{
    partial class GameGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guessButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.displayMessageLabel = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.rowcolumnLabel = new System.Windows.Forms.Label();
            this.txtGuessRow = new System.Windows.Forms.TextBox();
            this.txtGuessColumn = new System.Windows.Forms.TextBox();
            this.gridDisplayLabel = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(260, 261);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 0;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(483, 261);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(713, 12);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(30, 181);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // displayMessageLabel
            // 
            this.displayMessageLabel.AutoSize = true;
            this.displayMessageLabel.Location = new System.Drawing.Point(364, 70);
            this.displayMessageLabel.Name = "displayMessageLabel";
            this.displayMessageLabel.Size = new System.Drawing.Size(82, 13);
            this.displayMessageLabel.TabIndex = 5;
            this.displayMessageLabel.Text = "displayMessage";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(12, 130);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(39, 20);
            this.txtRows.TabIndex = 6;
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(84, 130);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(41, 20);
            this.txtColumns.TabIndex = 7;
            // 
            // rowcolumnLabel
            // 
            this.rowcolumnLabel.AutoSize = true;
            this.rowcolumnLabel.Location = new System.Drawing.Point(12, 91);
            this.rowcolumnLabel.Name = "rowcolumnLabel";
            this.rowcolumnLabel.Size = new System.Drawing.Size(113, 13);
            this.rowcolumnLabel.TabIndex = 8;
            this.rowcolumnLabel.Text = "Rows and Colums size";
            // 
            // txtGuessRow
            // 
            this.txtGuessRow.Location = new System.Drawing.Point(358, 264);
            this.txtGuessRow.Name = "txtGuessRow";
            this.txtGuessRow.Size = new System.Drawing.Size(42, 20);
            this.txtGuessRow.TabIndex = 9;
            // 
            // txtGuessColumn
            // 
            this.txtGuessColumn.Location = new System.Drawing.Point(415, 264);
            this.txtGuessColumn.Name = "txtGuessColumn";
            this.txtGuessColumn.Size = new System.Drawing.Size(43, 20);
            this.txtGuessColumn.TabIndex = 10;
            // 
            // gridDisplayLabel
            // 
            this.gridDisplayLabel.AutoSize = true;
            this.gridDisplayLabel.Location = new System.Drawing.Point(378, 112);
            this.gridDisplayLabel.Name = "gridDisplayLabel";
            this.gridDisplayLabel.Size = new System.Drawing.Size(58, 13);
            this.gridDisplayLabel.TabIndex = 11;
            this.gridDisplayLabel.Text = "gridDisplay";
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Location = new System.Drawing.Point(657, 170);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(80, 13);
            this.guessLabel.TabIndex = 12;
            this.guessLabel.Text = "Guess Count: 0";
            // 
            // GameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FindTheSampleGuessingGame.Properties.Resources.Bliss__Windows_XP_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.gridDisplayLabel);
            this.Controls.Add(this.txtGuessColumn);
            this.Controls.Add(this.txtGuessRow);
            this.Controls.Add(this.rowcolumnLabel);
            this.Controls.Add(this.txtColumns);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.displayMessageLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.guessButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "GameGUI";
            this.Text = "CSI: Find the Evidence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label displayMessageLabel;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label rowcolumnLabel;
        private System.Windows.Forms.TextBox txtGuessRow;
        private System.Windows.Forms.TextBox txtGuessColumn;
        private System.Windows.Forms.Label gridDisplayLabel;
        private System.Windows.Forms.Label guessLabel;
    }
}

