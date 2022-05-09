using System;

namespace FuncoesLocaisSemRetorno
{
    class Program
    {
        static void Main(string[] args)
        {
            //com passagem de parâmetros.
            MostrarUmTexto("É um texto aleatório.");
            SomarDoisNumeros(10.5, 20.3);
            //sem passagem de parâmetros.
            MultiplicarDoisValoresEstaticos();
        }
        static void MostrarUmTexto(string texto)
        {
            Console.WriteLine(texto);
        }
        static void SomarDoisNumeros(double n1, double n2) 
        {
            double res = n1 + n2;
            Console.WriteLine("A Soma é "+res);
        }
        static void MultiplicarDoisValoresEstaticos() 
        {
            double res = 20 * 50.5;
            Console.WriteLine("A multiplicação é"+res);
        }
    }
}
