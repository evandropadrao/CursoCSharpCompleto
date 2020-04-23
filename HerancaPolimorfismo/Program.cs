using System;
using System.Collections.Generic;
using System.Globalization;
using HerancaPolimorfismo.Entities;

namespace HerancaPolimorfismo
{
   class Program
   {
      static void Main(string[] args)
      {
         List<Product> products = new List<Product>();

         Console.Write("Enter the number of products: ");
         int count = int.Parse(Console.ReadLine());

         for (int i = 1; i <= count; i++)
         {
            Console.WriteLine();
            Console.WriteLine($"Product #{i} data:");

            Console.Write("Common, used or import (c/u/i)? ");
            char type = char.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (type == 'i')
            {
               Console.Write("Custom fee: ");
               double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               Product prod = new ImportedProduct(name, price, customFee);
               products.Add(prod);
            }
            else if (type == 'u')
            {
               Console.Write("Manufacture date: ");
               DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

               Product prod = new UsedProduct(name, price, date);
               products.Add(prod);
            }
            else if (type == 'c')
            {
               Product prod = new Product(name, price);
               products.Add(prod);
            }
            else
            {
               Console.WriteLine("[ERROR]: unknown product type");
            }
         }

         Console.WriteLine();
         Console.WriteLine("PRICE TAGS: ");

         foreach (var product in products)
         {
            Console.WriteLine(product.PriceTag());
         }
      }
   }
}
