using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheSampleGuessingGame
{
    internal class BloodAnalyzer : SampleAnalyzer
    {
        private (int row, int column)[] bloodSamples;

        public BloodAnalyzer(int rows, int cols) : base(rows, cols)
        {
            bloodSamples = new (int, int)[3]; // Example for storing up to 3 blood samples
            // Initialize blood samples randomly in the grid
            for (int i = 0; i < bloodSamples.Length; i++)
            {
                bloodSamples[i] = GetRandomLocation();
            }
        }

        public override void CollectEvidence()
        {
            base.CollectEvidence(); // Collect evidence from SampleAnalyzer

            foreach (var blood in bloodSamples)
            {
                grid[blood.row, blood.column] = 'B'; // Mark blood samples on the grid
            }
        }
    }
}
