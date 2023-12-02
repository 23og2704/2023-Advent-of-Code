using System;
using System.Collections.Generic;
using System.IO;
namespace _2023___1st__part_1_
{
    internal class Program
    {
        static bool isNum(char letter)
        {
            switch (letter)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return true;
                default:
                    return false;
            }
        }
        static void Main(string[] args)
        {
            using (StreamReader stream = new StreamReader("text.txt"))
            {
                List<string> list = new List<string>();
                while (!stream.EndOfStream)
                {
                    list.Add(stream.ReadLine());
                }
                int result = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    list[j] = list[j].Replace("zero", "zero0zero").Replace("one", "one1one").Replace("two", "two2two").Replace("three", "three3three").Replace("four", "four4four").Replace("five", "five5five").Replace("six", "six6six").Replace("seven", "seven7seven").Replace("eight", "eight8eight").Replace("nine", "nine9nine");
                    string total = "";
                    for (int i = 0; i < list[j].Length; i++)
                    {
                        if (isNum(list[j][i]))
                        {
                            total += list[j][i];
                            break;
                        }
                    }
                    for (int i = list[j].Length - 1; i > -1; i--)
                    {
                        if (isNum(list[j][i]))
                        {
                            total += list[j][i];
                            break;
                        }
                    }
                    Console.WriteLine(total);
                    result += int.Parse(total);
                    Console.WriteLine(result);
                }
                Console.ReadKey();
            }
        }
    }
}


