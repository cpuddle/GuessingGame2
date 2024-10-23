using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheSampleGuessingGame
{
    internal class SampleAnalyzer : Analyzer
    {
        protected (int row, int column) sample;

        public SampleAnalyzer(int rows, int cols) : base(rows, cols)
        {
            sample = GetRandomLocation();
        }

        public override void CollectEvidence()
        {
            grid[sample.row, sample.column] = 'S'; // Mark the sample on the grid
        }

        protected (int rows, int cols) GetRandomLocation()
        {
            int randomRow = rand.Next(0, grid.GetLength(0));
            int randomColumn = rand.Next(0, grid.GetLength(1));
            return (randomRow, randomColumn);
        }
    }
}
