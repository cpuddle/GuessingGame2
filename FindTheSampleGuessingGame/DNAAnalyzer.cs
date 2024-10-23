using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheSampleGuessingGame
{
    internal class DNAAnalyzer : SampleAnalyzer
    {
        private (int row, int column)[] dnaSamples;

        public DNAAnalyzer(int rows, int cols) : base(rows, cols)
        {
            dnaSamples = new (int, int)[3]; // Example for storing up to 3 DNA samples
            // Initialize DNA samples randomly in the grid
            for (int i = 0; i < dnaSamples.Length; i++)
            {
                dnaSamples[i] = GetRandomLocation();
            }
        }

        public override void CollectEvidence()
        {
            base.CollectEvidence(); // Collect evidence from SampleAnalyzer

            foreach (var dna in dnaSamples)
            {
                grid[dna.row, dna.column] = 'D'; // Mark DNA samples on the grid
            }
        }
    }
}