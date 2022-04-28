using System;

namespace LacosDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int a = 1000;
            string texto = "Uma cadeia de textos é percorrida assim";

            //for
            //para i igual 0, itere i enquanto este for menor 1000 e mostre ele na tela. 
            for (int i =0; i< 1000; i++) 
            {
                Console.WriteLine("Valor de i: "+i);
            }

            //while
            //enquanto j for menor que 10000, mostre o valor de j na tela.   
            while (j<10000) 
            {
                Console.WriteLine("Valor de j: " + j);
                j++;
            }

            //do-while 
            //mostre na tela o valor de "a" enquanto este for maior que zero.
            do
            {
                Console.WriteLine("Valor de j: " + a);
                a--;
            }
            while (a > 0);

            //foreach
            //para itere para cada char "b" na cadeia de caracteres  
            foreach (char b in texto) 
            {
                //texto.IndexOf(b) encontra a primeira ocorrência da letra em "b" e retorna sua posição no array.
                Console.WriteLine($"Texto na posição {texto.IndexOf(b)}, {b}" );
            }
        }
    }
}
