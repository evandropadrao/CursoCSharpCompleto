using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Excecoes.Exceptions
{
   class DomainException : Exception
   {
      public DomainException(string message) : base(message)
      {
      }
   }
}
