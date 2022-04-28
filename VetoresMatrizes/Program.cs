using System;

namespace VetoresMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorInteiro = new int[50];
            char[] vetorChar = new char[10];
            int iVetorChar = 0;
            int vetorCharLenght = vetorChar.Length;
            string[] vetorNomes = new string[10];
            int iVetorNomes = 0;


            //preenchendo um vetor usando for
            for(int i = 0; i < vetorInteiro.Length; i++)
            {
                Console.WriteLine("Insira um número");
                vetorInteiro[i] = Convert.ToInt32(Console.ReadLine());
            }

            //preenchendo um vetor usando while

            while (iVetorChar < vetorCharLenght) 
            {
                Console.WriteLine("Insira um caractere");
                vetorChar[iVetorChar] = Convert.ToChar(Console.ReadLine());
                iVetorChar++;
            }

            //preenchendo um vetor usando do-while

            do
            {
                iVetorNomes++;
                Console.WriteLine("Insira um nome");
                vetorNomes[iVetorNomes] = Console.ReadLine();
            } 
            while (iVetorNomes < vetorNomes.Length);

            //preenchendo um vetor usando foreach (objeto, nesse caso um vetor de strings)




        }
    }
}
