using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2023___1st__part_1_
{
    internal class Program
    {

        static int find(List<string> text)
        {
            int num = 0;
            foreach (string s in text)
            {
                string total = "";
                foreach (char letter in s)
                {

                    switch (letter.ToString())
                    {
                        case "1":
                            total += "1";
                            break;
                        case "2":
                            total += "2";
                            break;
                        case "3":
                            total += "3";
                            break;
                        case "4":
                            total += "4";
                            break;
                        case "5":
                            total += "5";
                            break;
                        case "6":
                            total += "6";
                            break;
                        case "7":
                            total += "7";
                            break;
                        case "8":
                            total += "8";
                            break;
                        case "9":
                            total += "9";
                            break;
                        default:
                            total += "0";
                            break;
                    }
                }
                num += total[0] * 10;
                total = total.Reverse().ToString();
                num += total[0];
                Console.WriteLine(num);
            }
            return num;
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
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
                find(list);
                Console.ReadKey();



            }
        }
    }
}
