using System;
using System.Globalization;
using Exercicio_EnumeracaoComposicao.Entities;
using Exercicio_EnumeracaoComposicao.Entities.Enum;

namespace Exercicio_EnumeracaoComposicao
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine();
         Console.WriteLine("Enter client data:");
         Console.Write("Name: ");
         string name = Console.ReadLine();
         Console.Write("Email: ");
         string email = Console.ReadLine();
         Console.Write("Birth Date (DD/MM/YYYY): ");
         DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

         Client client = new Client(name, email, date);

         Console.WriteLine();
         Console.WriteLine("Enter order data:");
         Console.Write("Status: ");
         OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
         Order order = new Order(DateTime.Now, status);

         Console.WriteLine();
         Console.Write("How many itens to this order? ");
         int count = int.Parse(Console.ReadLine());

         for (int i = 1; i <= count; i++)
         {
            Console.WriteLine();
            Console.WriteLine($"Enter #{i} item data:");
            Console.Write("Product Name: ");
            string prodName = Console.ReadLine();
            Console.Write("Product Price: ");
            double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(prodName, prodPrice);

            OrderItem item = new OrderItem(quantity, prodPrice, product);

            order.AddItem(item);
         }

         Console.WriteLine();
         Console.WriteLine("ORDER SUMMARY: ");
         Console.WriteLine($"Order moment: {order.Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
         Console.WriteLine($"Order Status: {order.Status}");
         Console.WriteLine();
         Console.WriteLine($"Client: {client}");

         if (order.Items.Count > 0)
         {
            Console.WriteLine();
            Console.WriteLine("Order itens: ");

            foreach (var item in order.Items)
            {
               Console.WriteLine(item);
            }

            Console.WriteLine($"Totak price: ${order.Total().ToString("F2")}");
         }
      }
   }
}
