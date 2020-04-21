using System;
using ControlePedidos.Entities;
using ControlePedidos.Entities.Enums;

namespace ControlePedidos
{
   class Program
   {
      static void Main(string[] args)
      {
         Order order = new Order();
         order.Id = 100;
         order.Moment = DateTime.Now;
         order.Status = OrderStatus.PendingPayment;

         Console.WriteLine(order);

         Order newOrder = new Order
         {
            Id = 101,
            Moment = DateTime.Now.AddDays(1),
            Status = OrderStatus.Processing
         };

         Console.WriteLine(newOrder);
         newOrder.Status = Enum.Parse<OrderStatus>("Shipped");
         Console.WriteLine(newOrder);
      }
   }
}
