using System;

namespace lorintz0121
{
    public class SportsEvent
    {
        private double[] scores = new double[8];

        /// <summary>
        /// This method prompts the user to enter in 8 scores and stores
        /// them in the array scores.
        /// </summary>
        public void ReadScores()
        {
            // TODO : Implement reading 8 scores from the user
            scores = new double[8];
            Console.WriteLine("Enter Eight Contestant Scores:");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"Judge {i + 1} --> ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double score))
                {
                    scores[i] = score;
                }
                else
                {
                    Console.WriteLine("Wrong value, try again!");
                    i--; // Decrement i to repeat this iteration
                }
            }
        }

        /// <summary>
        /// Determines which score in scores is the lowest
        /// </summary>
        /// <returns>The lowest score in scores</returns>
        public double Lowest()
        {
            // TODO : Determine the lowest score
            return 0;
        }

        /// <summary>
        /// Determines which score in scores is the highest
        /// </summary>
        /// <returns>The highest score in scores</returns>
        public double Highest()
        {
            // TODO : Determine the highest score
            return 0;
        }

        /// <summary>
        /// Calculates the average of scores with the lowest and highest scores
        /// thrown out.
        /// </summary>
        /// <returns>The average</returns>
        public double Average()
        {
            // TODO : Calculate the average without lowest and highest score
            return 0;
        }

        /// <summary>
        /// This method prints a summary report which includes the original list of
        /// scores, the average of the scores, the lowest score, and the highest score.
        /// </summary>
        public void PrintSummary()
        {
            // TODO : Print summary report
        }

        /// <summary>
        /// Program entry point.
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        public static void Main(string[] args)
        {
            SportsEvent app = new SportsEvent();
            app.ReadScores();
            app.PrintSummary();
        }
    }
}
