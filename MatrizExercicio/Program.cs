using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            Console.WriteLine($"A matriz possui  {n} linhas e  {n} colunas, então digite  {n} números por linha separados por espaço:");

            for(int i = 0; i < mat.GetLength(0); i++)
            {
               string[] recebe=Console.ReadLine().Split(' ');

                for(int j=0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = double.Parse(recebe[j]);
                }
            }


            Console.WriteLine("Diagonal Principal: ");
            
            for(int i=0; i<n; i++)
            {

                Console.Write(mat[i,i]+" ");
            }


            int numero = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                

                for (int j = 0; j < mat.GetLength(1); j++)
                {
                   if (mat[i,j] < 0)
                    {
                        numero++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Números negativos: "+numero);
        }
    }
}