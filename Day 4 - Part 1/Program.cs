using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day_4___Part_1
{
    internal class Program
    {
        static int calculator(List<string> winNums, List<string> Nums)
        {
            int points = 0;
            foreach (string num in Nums)
            {
                if (winNums.Contains(num))
                {
                    points++;
                }
            }
            return (int)Math.Pow(2, points - 1);
        }

        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");
            int points = 0;

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                List<string> winNums = parts[0].Split().Select(x => x.Trim()).ToList();
                while (winNums.Contains("")) winNums.Remove("");
                List<string> Nums = parts[1].Split().Select(x => x.Trim()).ToList();
                while (Nums.Contains("")) Nums.Remove("");
                int temp = calculator(winNums, Nums);
                points += temp;
            }

            Console.WriteLine(points);
            Console.ReadKey();
        }
    }
}
