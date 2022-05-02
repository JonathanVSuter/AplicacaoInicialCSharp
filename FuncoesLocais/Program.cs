using System;
using System.Text;

namespace FuncoesLocais
{
    class Program
    {        
        static void Main(string[] args)
        {
            //a função RetornarTextoParamostrar recebe um parâmetro do tipo string, esta fará o processamento e retornará o valor (do tipo string).
            Console.WriteLine(RetornarTextoParamostrar("Hello World!"));

            //quando não há parâmetros especificados, a função não recebe parâmetros em sua chamada
            //ainda nesse caso, ela não possui retorno;
            PedirEntradaParaSomaDeDoisNumeros();

            //pede ao usuário que informe um texto para processamento;
            Console.WriteLine("Insira um texto para quebrar");
            string entrada = Console.ReadLine();

            //retorna a string como um array de char
            char[] retorno = QuebrarString(entrada);

            //imprime na tela o retorno
            foreach (char item in retorno) 
            {
                Console.WriteLine(item);
            }

            entrada = MontarString(retorno);

            Console.WriteLine("vetor de char reconvertido em String: " + entrada);
        }

        //esta função retorna um texto, interpolado com o parâmetro passado.
        static string RetornarTextoParamostrar(string texto) 
        {
            return $"Texto para retornar na principal: {texto}";
        }

        //Soma dois números e retorna o valor total. 
        static int SomarNumeros(int a, int b) 
        {
            return a + b;
        }

        //Mesma função que SomarNumeros, porém, soma valores diferentes.
        //O compilador entende que, por receberem valores de tipos diferentes, têm assinaturas diferentes e são diferentes.
        static double SomarNumeros(double a, double b)
        {
            return a + b;
        }

        //esta função apenas executa um bloco de operações e não possui retorno.
        static void PedirEntradaParaSomaDeDoisNumeros() 
        {
            int num1;
            int num2;
            double num1d;
            double num2d;

            Console.WriteLine("Insira um valor para num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira um valor para num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            //a linguagem infere que é a função com retorno de inteiro
            int retorno = SomarNumeros(num1, num2);
            Console.WriteLine("O valor da soma é: "+retorno);

            Console.WriteLine("Insira um valor para num1d");
            num1d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira um valor para num2d");
            num2d = Convert.ToDouble(Console.ReadLine());
            double retornoDouble = SomarNumeros(num1d, num2d);
            Console.WriteLine("O valor da soma é: " + retornoDouble);            
        }

        //quebra uma string em um vetor de char
        static char[] QuebrarString(string texto)
        {
            char[] textoQuebrado = new char[texto.Length];

            for (int i = 0; i < texto.Length; i++) 
            {
                textoQuebrado[i] = texto[i];
            }

            return textoQuebrado;
        }
        static string MontarString(char[] texto) 
        {
            StringBuilder retorno = new StringBuilder();
            
            foreach(char item in texto) 
            {
                retorno.Append(item);
            }

            return retorno.ToString();
        }
    }
}
