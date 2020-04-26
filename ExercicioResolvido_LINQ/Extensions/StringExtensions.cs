
namespace System
{
   static class StringExtensions
   {
      public static string ParseHome(this string path)
      {
         string home = (Environment.OSVersion.Platform == PlatformID.Win32NT)
            ? Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%")
            : Environment.GetEnvironmentVariable("HOME");

         return path.Replace("~", home);
      }

      public static string ParsePath(this string path)
      {
         string home = @"C:\Pessoal\Cursos\CSharp\Projetos\CursoCSharp_Completo";

         return path.Replace("~", home);
      }
   }
}
