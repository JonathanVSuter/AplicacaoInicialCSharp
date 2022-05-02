using System;

namespace ContarElementosRepetidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int entradas;
            Console.WriteLine("Insira a quantidade de valores");
            entradas = Convert.ToInt32(Console.ReadLine());

            int[] vetorEntradas = new int[entradas];
            int[] vetorEntradasCopia = new int[entradas];
            int[] contarNumerosRepetidos = new int[entradas];
            int[] marcarEntradasRepetidas = new int[entradas];

            for (int i = 0; i < vetorEntradas.Length; i++)
            {
                vetorEntradas[i] = Convert.ToInt32(Console.ReadLine());
                vetorEntradasCopia[i] = vetorEntradas[i];
            }

            for(int i = 0; i < vetorEntradas.Length; i++) 
            {
                for(int j = 0; j < vetorEntradas.Length; j++)
                {
                    if (i != j) 
                    {
                        if (vetorEntradas[i] == vetorEntradasCopia[j] && marcarEntradasRepetidas[j] == 0)
                        {
                            contarNumerosRepetidos[i]++;
                            marcarEntradasRepetidas[i] = 1;
                            marcarEntradasRepetidas[j] = -1;
                        }
                    }                    
                }                
            }

            for (int i = 0; i < contarNumerosRepetidos.Length; i++ ) 
            {
                if (contarNumerosRepetidos[i] > 0 && marcarEntradasRepetidas[i] > 0) 
                {
                    Console.WriteLine($"O elemento {vetorEntradas[i]} na posição {i} repete {contarNumerosRepetidos[i]} vezes.");
                }
            }
        }
    }
}
