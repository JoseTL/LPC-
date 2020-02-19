using System;


namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int m,n;
            int[,] A;
            string[] s1=Console.ReadLine().Split(' '); q                
            m = int.Parse(s1[0]);
            n = int.Parse(s1[1]);
            A = new int[m,n];

            for(int i=0; i<m; i++){
                string[]s = Console.ReadLine().Split(' ');
                for(int j=0; j<n;j++){
                    A[i,j]= int.Parse(s[j]);

                }

            }
            for(int i=0; i<m; i++){
                for(int j= 0; j<n; j++){
                   Console.Write(A[i,j] + " ");

                }
            }
            Console.ReadLine();


        
        }
    }
}
