﻿using System;
namespace Warehouse
{
    internal class Program
    {
        //Stała
        public const string FILE_NAME = "C:\\WarehouseFiles\\ImportFile.xlsx";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Warehouse app");
            Console.WriteLine("Please let me know what you want to do:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Check Item");
            Console.WriteLine("Press 1, 2 or 3...");

            string choice = Console.ReadLine();

            Console.WriteLine($"You have chosen option number: {choice}");

            

            //Zmienna
            int chosenOption = 0;
            Int32.TryParse(choice, out chosenOption );

            Item item = new Item() { Id = 1, Name = "Apple"};

            int a = 5;
            int b = a;

            Console.WriteLine(a);
            Console.WriteLine(b);



        }
    }
}