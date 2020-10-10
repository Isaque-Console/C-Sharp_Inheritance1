using System;
using System.Collections.Generic;
using System.Globalization;
using Inheritance1.Entities;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i<number;i++)
            {
                Console.WriteLine($"PRODUCT #{i+1} DATA:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char verification = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (verification == 'c')
                {
                    products.Add(new Product(name,price));
                }
                else if(verification == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
