using System;


//casting é a converção explicita de um tipo para outro, 
//nesse exemplo ele coverte valor int para double/float
namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            double resultado; 
            double x;
            int y;
             a = 5;
             b = 2;
             x = 7.0;
             y = (int) x; // para converter valor float/double para int

            resultado = (double) a / b; // (double) na frente para converter valor int para float
             Console.WriteLine( " O resultado da divisão é " + resultado + "\n e o valor y é " + y);
             Console.ReadLine();
             
             
        }
    }
}
