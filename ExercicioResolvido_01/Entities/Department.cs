using System;

namespace ExercicioResolvido_01.Entities
{
   class Department
   {
      public string Name { get; set; }

      public Department()
      {
      }

      public Department(string name)
      {
         Name = name ?? throw new ArgumentNullException(nameof(name));
      }

      public override string ToString()
      {
         return Name;
      }
   }
}
