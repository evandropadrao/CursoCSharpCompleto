
namespace System
{
   static class StringExtensions
   {
      public static string ParseHome(this string path)
      {
         string home = @"C:\Pessoal\Cursos\CSharp\Projetos\CursoCSharp_Completo";

         return path.Replace("~", home);
      }
   }
}
