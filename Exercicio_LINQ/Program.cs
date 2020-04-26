using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Exercicio_LINQ.Entities;

namespace Exercicio_LINQ
{
   class Program
   {
      static void Main(string[] args)
      {
         List<Product> products = new List<Product>();

         try
         {
            string productsFile = @"~\products.csv".ParseHome();

            if (File.Exists(productsFile))
            {
               // Monta a lista de produtos a partir do arquivo CSV de entrada
               Console.WriteLine("Products list:");
               using (StreamReader sr = File.OpenText(productsFile))
               {
                  while (!sr.EndOfStream)
                  {
                     string line = sr.ReadLine();
                     Console.WriteLine(line);

                     string[] fields = line.Split(',');

                     string name = fields[0];
                     double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                     products.Add(new Product(name, price));
                  }
               }

               var average = products.Select(p => p.Price).DefaultIfEmpty(0.00).Average();
               Console.WriteLine("Average price: " + average.ToString("F2", CultureInfo.InvariantCulture));

               var names = products.Where(p => p.Price < average).OrderByDescending(p => p.Name).Select(p => p.Name);
               foreach (var name in names)
               {
                  Console.WriteLine(name);
               }
            }
            else
            {
               Console.WriteLine($"[ERROR]: file '{productsFile}' doesn't exist!");
            }
         }
         catch (IOException ex)
         {
            Console.WriteLine("[FAILURE]: " + ex.Message);
         }
         catch (Exception ex)
         {
            Console.WriteLine("[ERROR]: " + ex.Message);
         }
      }
   }
}
