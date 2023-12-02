﻿using System;
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
        static string IDFinder(string line)
        {
            string[] ID = line.Split(':');
            string[] num = ID[0].Split(' ');
            return num[1];
        }
        static void Main(string[] args)
        {
            List<string> lines = new List<string>(File.ReadAllLines("Input 2.txt"));
            List<int> IDs = new List<int>();
            int result = 0;
            foreach (string line in lines)
            {
                int id = int.Parse(IDFinder(line));
                Console.WriteLine(line);
                int[] numofcol = { 0, 0, 0 };
                string[] splitstring = line.Split(':');
                string[] sections = splitstring[1].Split(';');
                foreach (string section in sections)
                {
                    Console.WriteLine($"Section: {section}");
                    string[] parts = section.Split(',');
                    foreach (string part in parts)
                    {
                        Console.WriteLine($"Part: {part}");
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
                            }
                        }

                    }
                    Console.WriteLine($"Red: {numofcol[0]}, Green: {numofcol[1]}, Blue: {numofcol[2]}");
                }
                if (numofcol[0] <= 12 && numofcol[1] <= 13 && numofcol[2] <= 14)
                {
                    result += id;
                    IDs.Add(id);
                }
                Console.Write($"Id's Possible: ");
                foreach (int val in IDs)
                    Console.Write($"{val}, ");
                Console.WriteLine($"Result: {result}");

            }
            Console.ReadKey();
        }
    }
}