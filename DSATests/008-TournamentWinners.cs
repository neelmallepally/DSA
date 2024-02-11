using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSATests
{
    // PROBLEM: TOURNAMENT WINNER
    // 

    // competition  = [ [home_team, away_team ]]
    // result = [0] ==> away_team won
    // result = [1] ==> means home_team won.

    public class _008_TournamentWinners
    {

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { new[,] {
                { "HTML", "C#" },
                { "C#", "Python" }, 
                { "Python", "HTML" } }, 
                new[] {0, 0, 1 }, 
                "Python" };

            yield return new object[] { new[,] {
                { "HTML", "Java" },
                { "Java", "Python" },
                { "Python", "HTML" } },
                new[] {0, 1, 1 },
                "Java" };

            yield return new object[] { new[,] {
                { "Bulls", "Eagles" },
            },
                new[] {1},
                "Bulls" };
        }


        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(string[,] competitions, int[] results, string expectedWiner)
        {
            var actual = GetWinner(competitions, results);
            Assert.Equal(expectedWiner, actual);
        }


        private string GetWinner(string[,] competitions, int[] results)
        {
            Dictionary<string, int> tracker = new Dictionary<string, int>();
            for (int i = 0; i < competitions.GetLength(0); i++)
            {
                var winner = results[i] > 0 ? competitions[i,0] : competitions[i,1];

                if (tracker.ContainsKey(winner))
                    tracker[winner] +=3;
                else
                    tracker.Add(winner, 3);
            }

            return tracker.First(x => x.Value == tracker.Values.Max()).Key;
        }
    }
}
