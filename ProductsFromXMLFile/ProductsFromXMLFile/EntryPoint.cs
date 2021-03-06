﻿using System;

namespace ProductsFromXMLFile
{
    /// <summary>
    /// Entry point.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                {
                    throw new ArgumentException("Wrong number of arguments.");
                }

                string filePath = args[0];
                double maxPrice = Double.Parse(Console.ReadLine());
                DateTime date = new DateTime(2019, 6, 30);
                ProductXMLConverter productXMLConverter = new ProductXMLConverter();
                var products = productXMLConverter.GetProducts(filePath);

                foreach (var i in products)
                {
                    if (i.Price <= maxPrice && i.Date >= date)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch(Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}