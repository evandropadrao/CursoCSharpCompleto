using ExercicioResolvido_02.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioResolvido_02
{
   class Program
   {
      static void Main(string[] args)
      {
         Post post1 = new Post(DateTime.ParseExact("21/06/2017 13:05:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
               "Traveling to New Zeland",
               "I'm going to visit this wonderful country!",
               12);

         post1.AddComment(new Comment("Have a nice trip!"));
         post1.AddComment(new Comment("Wow  that's awesome!"));

         Post post2 = new Post(DateTime.ParseExact("28/07/2018 23:14:19", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
               "Goog night guys!",
               "See you tomorrow.",
               5);

         post2.AddComment(new Comment("Good night!"));
         post2.AddComment(new Comment("May the Force be with you."));

         Console.WriteLine(post1);
         Console.WriteLine(post2);

      }
   }
}
