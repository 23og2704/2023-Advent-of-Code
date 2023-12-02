using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Schema;

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
                foreach (string line in list)
                {
                    string total = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (isNum(line[i]))
                        {
                            total += line[i];
                            break;
                        }
                    }
                    for (int i = line.Length - 1; i > -1; i--)
                    {
                        if (isNum(line[i]))
                        {
                            total += line[i];
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






