using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 100, b1 = 50;            

            bool resultadoInt;

            resultadoInt = ((a1 > b1) && (a1 <= 200));
            Console.WriteLine("resultadoInt com o operador AND " + resultadoInt);

            resultadoInt = (a1 > b1) || (a1 > 100);
            Console.WriteLine("resultadoInt com o operador OU " + resultadoInt);

            resultadoInt = !resultadoInt;
            Console.WriteLine("resultadoInt com o operador de Negação " + resultadoInt);
        }
    }
}
