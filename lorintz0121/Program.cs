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
        }

        /// <summary>
        /// Determines which score in scores is the lowest
        /// </summary>
        /// <returns>The lowest score in scores</returns>
        public double Lowest()
        {
            double lowestScore = 0;

            foreach (var s in scores)
            {
                if (s < lowestScore)
                    lowestScore = s;
            }

            return lowestScore;
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
            double divBy = 0;
            double sum = 0;
            double[] newArray = new double[6];
            int index = 0;

            foreach (var s in scores)
            {
                if (s != Lowest() && s != Highest())
                {
                    newArray[index] = s;
                    index++;
                }
            }

            foreach (var s in newArray)
            {
                sum += s;
                divBy++;
            }
            // TODO : Calculate the average without lowest and highest score
            return sum / divBy;
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
