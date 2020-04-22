using System;

namespace ExercicioResolvido_01.Entities
{
   class HourContract
   {
      public DateTime Date { get; set; }
      public double ValuePerHour { get; set; }
      public int Hours { get; set; }

      public HourContract()
      {
      }

      public HourContract(DateTime date, double valuePerHour, int hours)
      {
         Date = date;
         ValuePerHour = valuePerHour;
         Hours = hours;
      }

      public double TotalValue()
      {
         return ValuePerHour * Hours;
      }

      public override bool Equals(object obj)
      {
         var contract = obj as HourContract;
         return contract != null &&
                Date == contract.Date &&
                ValuePerHour == contract.ValuePerHour &&
                Hours == contract.Hours;
      }

      public override int GetHashCode()
      {
         return HashCode.Combine(Date, ValuePerHour, Hours);
      }

      public override string ToString()
      {
         return Date
            + ", "
            + ValuePerHour
            + ", "
            + Hours;
      }
   }
}
