﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_LINQ.Entities
{
   class Product
   {
      public string Name { get; set; }
      public double Price { get; set; }

      public Product(string name, double price)
      {
         Name = name;
         Price = price;
      }
   }
}
