using System;
using System.Collections.Generic;
using System.IO;

namespace December_2nd
{
    internal class Program
    {
        static bool isNum(string num)
        {
            int number = 0;
            bool result = Int32.TryParse(num, out number);
            return result;
        }
        static int CalculatePower(int[] cubes)
        {
            return cubes[0] * cubes[1] * cubes[2];
        }

        static void Main(string[] args)
        {
            List<string> lines = new List<string>(File.ReadAllLines("games.txt"));
            int result = 0;

            foreach (string line in lines)
            {
                int[] numofcol = { 0, 0, 0 };
                string[] splitstring = line.Split(':');
                string[] sections = splitstring[1].Split(';');

                foreach (string section in sections)
                {
                    string[] parts = section.Split(',');
                    foreach (string part in parts)
                    {
                        string num = "";
                        string[] keys = part.Split(' ');

                        foreach (string key in keys)
                        {
                            if (isNum(key) == true)
                            {
                                num += key;
                            }
                            else
                            {
                                switch (key)
                                {
                                    case "red":
                                        if (int.Parse(num) > numofcol[0]) numofcol[0] = int.Parse(num);
                                        break;
                                    case "green":
                                        if (int.Parse(num) > numofcol[1]) numofcol[1] = int.Parse(num);
                                        break;
                                    case "blue":
                                        if (int.Parse(num) > numofcol[2]) numofcol[2] = int.Parse(num);
                                        break;
                                }
                                num = "";
                            }
                        }
                    }
                }

                // Console.WriteLine($"Red: {numofcol[0]}, Green: {numofcol[1]}, Blue: {numofcol[2]}");

                int power = CalculatePower(numofcol);
                result += power;

                Console.WriteLine($"Power: {power}");
            }

            Console.WriteLine($"Sum of powers: {result}");
            Console.ReadKey();
        }
    }
}
