using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace December_4_Part2
{
    internal class Program
    {
        static int compareNumbers(List<string> winNums, List<string> Nums)
        {
            int points = 0;
            for (int i = 0; i < Nums.Count; i++)
            {
                if (winNums.Contains(Nums[i]))
                {
                    points++;
                }
            }
            return points;
        }
        static int splitCompare(string line)
        {
            string[] split = line.Split(':')[1].Trim().Split('|');
            List<string> winNums = new List<string>(split[0].Trim().Split(' '));
            winNums.RemoveAll(string.IsNullOrEmpty); // fancy while replace
            List<string> Nums = new List<string>(split[1].Trim().Split(' '));
            Nums.RemoveAll(string.IsNullOrEmpty);
            return compareNumbers(winNums, Nums);
        }
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");
            int[] totalCards = Enumerable.Repeat(1, lines.Length).ToArray(); // thanks to gitman
            for (int lineNumber = 0; lineNumber < lines.Length; lineNumber++)
            {
                int match = splitCompare(lines[lineNumber]);
                for (int i = lineNumber + 1; i <= lineNumber + match; i++)
                {
                    totalCards[i] += totalCards[lineNumber];
                }
            }
            Console.WriteLine(totalCards.Sum());
            Console.ReadKey();
        }
    }
}
