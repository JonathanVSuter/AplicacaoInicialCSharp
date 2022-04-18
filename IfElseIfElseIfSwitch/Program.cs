using System;

namespace IfElseIfElseIfSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, b1;

            bool resultadoInt;

            //Console.ReadLine() serve para pegar a entrada de dados do usuário
            //Convert.ToInt32() converte o valor da entrada para um inteiro.
            Console.WriteLine("Insira um valor para a1:");
            a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira um valor para b1:");
            b1 = Convert.ToInt32(Console.ReadLine());

            resultadoInt = a1 > b1;

            //if else
            if (resultadoInt) 
            {
                Console.WriteLine("a1 é maior que b1:");
            }
            else
            {
                Console.WriteLine("a1 é menor que b1:");
            }

            //if else if
            if (resultadoInt) 
            {
                Console.WriteLine("a1 é maior que b1:");
            }
            else if(a1 > 100)
            {
                Console.WriteLine("a1 é maior que 100:");
            }
        }
    }
}
