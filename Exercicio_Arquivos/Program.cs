using System;
using System.Globalization;
using System.IO;
using Exercicio_Arquivos.Entities;

namespace Exercicio_Arquivos
{
   public static class ExtensaoString
   {
      public static string ParseHome(this string path)
      {
         string home = @"C:\Pessoal\Cursos\CSharp\Projetos\CursoCSharp_Completo";

         return path.Replace("~", home);
      }
   }

   class Program
   {
      static void Main(string[] args)
      {
         try
         {
            string sourceFile = @"~\arquivo.csv".ParseHome();

            if (File.Exists(sourceFile))
            {
               string targetDirectory = Path.GetDirectoryName(sourceFile) + @"\out";
               string targetFile = targetDirectory + @"\summary.csv";

               if (!Directory.Exists(targetDirectory))
               {
                  Directory.CreateDirectory(targetDirectory);
               }

               // Apaga para evitar erro a cada execucao de teste ou duplicar o conteudo
               if (File.Exists(targetFile))
               {
                  File.Delete(targetFile);
               }

               //var texto = sr.ReadToEnd();
               string[] lines = File.ReadAllLines(sourceFile);

               foreach (var line in lines)
               {
                  string[] fields = line.Split(',');

                  string name = fields[0];
                  double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                  int quantity = int.Parse(fields[2]);

                  Product product = new Product(name, price, quantity);

                  using (StreamWriter wr = File.AppendText(targetFile))
                  {
                     wr.WriteLine($"{product.Name},{product.Total().ToString("F2", CultureInfo.InvariantCulture)}");
                  }
               }
            }
            else
            {
               Console.WriteLine("[ERROR]: file doesn't exist!");
            }
         }
         catch (IOException ex)
         {
            Console.WriteLine("[ERROR]: " + ex.Message);
         }
      }
   }
}
