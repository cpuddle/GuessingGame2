﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTheSampleGuessingGame
{
    public partial class AnalyzerSelectionGUI : Form
    {
        public string SelectedAnalyzerType { get; private set; }

        public AnalyzerSelectionGUI()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (radioFingerprint.Checked)
                SelectedAnalyzerType = "fingerprint";
            else if (radioHair.Checked)
                SelectedAnalyzerType = "hair";
            else
            {
                MessageBox.Show("Please select an analyzer type.");
                return;
            }

            this.DialogResult = DialogResult.OK; // Indicate success
            this.Close(); // Close the selection form
        }

    }
}
