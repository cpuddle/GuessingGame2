namespace FindTheSampleGuessingGame
{
    partial class AnalyzerSelectionGUI
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
            this.radioHair = new System.Windows.Forms.RadioButton();
            this.radioFingerprint = new System.Windows.Forms.RadioButton();
            this.startGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioHair
            // 
            this.radioHair.AutoSize = true;
            this.radioHair.Location = new System.Drawing.Point(116, 183);
            this.radioHair.Name = "radioHair";
            this.radioHair.Size = new System.Drawing.Size(87, 17);
            this.radioHair.TabIndex = 0;
            this.radioHair.TabStop = true;
            this.radioHair.Text = "Hair Analyzer";
            this.radioHair.UseVisualStyleBackColor = true;
            // 
            // radioFingerprint
            // 
            this.radioFingerprint.AutoSize = true;
            this.radioFingerprint.Location = new System.Drawing.Point(264, 183);
            this.radioFingerprint.Name = "radioFingerprint";
            this.radioFingerprint.Size = new System.Drawing.Size(117, 17);
            this.radioFingerprint.TabIndex = 1;
            this.radioFingerprint.TabStop = true;
            this.radioFingerprint.Text = "Fingerprint Analyzer";
            this.radioFingerprint.UseVisualStyleBackColor = true;
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(369, 271);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(75, 23);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "OK";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // AnalyzerSelectionGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.radioFingerprint);
            this.Controls.Add(this.radioHair);
            this.Name = "AnalyzerSelectionGUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioHair;
        private System.Windows.Forms.RadioButton radioFingerprint;
        private System.Windows.Forms.Button startGameButton;
    }
}