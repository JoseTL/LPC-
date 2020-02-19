using System;
using System.Globalization;

namespace AlturaRetangulo
{
    class Program
    {
        static void Main(string[] args) 
        {
           double area, perimetro, diagonal, baze, altur;

           baze = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           altur = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            area = baze * altur;
            perimetro = 2 *(altur + baze);
            diagonal = Math.Sqrt(Math.Pow(baze, 2.0) + Math.Pow(altur, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}
