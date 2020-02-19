using System;
using System.Globalization;


namespace IdadeMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2; 
            int idade1, idade2;
            string[] vet;
            double media;

            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);


            media = (Double) (idade1 + idade2) / 2.0;

            Console.WriteLine(" A idade media de " + nome1 + "e " + nome2 + "é de" 
            + media.ToString("F1", CultureInfo.InstalledUICulture) + "anos")



        }
    }
}
