﻿using System;

namespace T06.ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            switch (countryName)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":  //Spain, Argentina, and Mexico
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
