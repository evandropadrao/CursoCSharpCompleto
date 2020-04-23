using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPolimorfismo.Entities
{
   class ImportedProduct : Product
   {
      public double CustomFee { get; set; }

      public ImportedProduct()
      {
      }

      public ImportedProduct(string name, double price, double customFee)
         : base(name, price)
      {
         CustomFee = customFee;
      }

      public double TotalPrice()
      {
         return Price + CustomFee;
      }

      public override string PriceTag()
      {
         return Name
            + " $ "
            + TotalPrice().ToString("F2")
            + " (Custom Fee: "
            + CustomFee.ToString("F2")
            + ")";
      }
   }
}
