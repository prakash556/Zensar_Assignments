using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2Assignment4
{
    internal class Cricket
    {
        static int no_of_matches;

        public Cricket()
        {
            Console.Write("Enter the Number of Matches:");
            no_of_matches = int.Parse(Console.ReadLine());
        }
        public void PointsCalculate(int no_of_match)
        {
            var score = new List<int>();
            for (int i = 0; i < no_of_match; i++)
            {
                Console.Write("Enter the score of match{0}: ",i+1);
                int j=int.Parse(Console.ReadLine());
                score.Add(j);
            }
            Console.WriteLine("Sum of the All Matches Scores is: "+ score.Sum());
            Console.WriteLine("Average of All the Matches Scores is:"+score.Average());

        }
        static void Main()
        {
            Cricket cricket = new Cricket();
            cricket.PointsCalculate(no_of_matches);
            Console.ReadKey();

        }
    }
}
