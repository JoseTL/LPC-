using System;
using System.Globalization;


namespace SegundoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
           double x = 10.30832123;
           double b;
           int a;
           int y = 32;
           string z = "Maria";
           char w = 'F';

           a = 7;
           b = 3 * a;

           Console.WriteLine(x); //imprimindo valor x
           Console.WriteLine(x.ToString("F2")); // para imprimir dois casas decimais com virgula (,)
           Console.WriteLine(x.ToString("F4")); // para imprimier 4 casas  decimais com virgula (,)
           Console.WriteLine(x.ToString("F5")); // para imprimir 5 casas decimais com virgula (,)
           Console.WriteLine(x.ToString("F3")); // para imprimir 3 casas decimais com virgula (,)
           Console.WriteLine(x.ToString("F2",CultureInfo.InvariantCulture)); //para imrimir 2 casas decimais com ponto (.)
           Console.WriteLine(x.ToString("F6",CultureInfo.InstalledUICulture)); //para imprimir 6 casas decimais com ponto (.)
           Console.WriteLine(); // quebra uma linha
           Console.WriteLine("RESULTADO = " + x);
           Console.WriteLine("O valor do troco é " + x + " reais");
           Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
           Console.WriteLine();
           Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
           Console.WriteLine();
           Console.WriteLine(a);
           Console.WriteLine(b);
           Console.ReadLine();



        }

    }
}
