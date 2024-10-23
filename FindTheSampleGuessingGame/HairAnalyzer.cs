using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheSampleGuessingGame
{
    internal class HairAnalyzer : SampleAnalyzer
    {
        private (int row, int column)[] hairSamples;

        public HairAnalyzer(int rows, int cols) : base(rows, cols)
        {
            hairSamples = new (int, int)[3]; // Example for storing up to 3 hair samples
            // Initialize hair samples randomly in the grid
            for (int i = 0; i < hairSamples.Length; i++)
            {
                hairSamples[i] = GetRandomLocation();
            }
        }

        public override void CollectEvidence()
        {
            base.CollectEvidence(); // Collect evidence from SampleAnalyzer

            foreach (var hair in hairSamples)
            {
                grid[hair.row, hair.column] = 'H'; // Mark hair samples on the grid
            }
        }
    }
}
