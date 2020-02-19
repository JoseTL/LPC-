using System;
using System.Globalization;

namespace EntradaSaidadeDados
{
    class Program
    {
        static void Main(string[] args)
        {
         string x;
         int y;
         double z;
         char w;
        Console.WriteLine("DIGITE AS INFORMAÇÕES:");

         x = Console.ReadLine();
         y = int.Parse(Console.ReadLine());
         z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         w = char.Parse(Console.ReadLine());
         Console.WriteLine("O texto que você digitou foi: " + x);
         Console.WriteLine("O valor inteiro que você digitou é " + y);
         Console.WriteLine("Valor decimal apresenta é:");
         Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));
         Console.WriteLine( "O caratere que vocẽ informou é :  " + w);

         Console.ReadLine();
         
           
        }
    }
}
