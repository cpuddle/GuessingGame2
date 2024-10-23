using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheSampleGuessingGame
{
    internal class FingerprintAnalyzer : Analyzer
    {
        private (int row, int column)[] fingerprints;

        public FingerprintAnalyzer(int rows, int cols) : base(rows, cols)
        {
            fingerprints = new (int, int)[5]; // Example for storing up to 5 fingerprints
            // Initialize fingerprints randomly in the grid
            for (int i = 0; i < fingerprints.Length; i++)
            {
                fingerprints[i] = GetRandomLocation();
            }
        }

        public override void CollectEvidence()
        {
            foreach (var fingerprint in fingerprints)
            {
                grid[fingerprint.row, fingerprint.column] = '@'; // Mark fingerprints on the grid
            }
        }

        private (int rows, int cols) GetRandomLocation()
        {
            int randomRow = rand.Next(0, grid.GetLength(0));
            int randomColumn = rand.Next(0, grid.GetLength(1));
            return (randomRow, randomColumn);
        }
    }
}
