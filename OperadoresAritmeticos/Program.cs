using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 100, b1 = 50, resultadoInt;
            double a2 = 50, b2 = 100, resultadoDouble;
            string texto1 = "Sou uma cadeia de texto", texto2 = " do C#", resultadoTextos;

            //Soma
            resultadoInt = a1 + b1;
            resultadoDouble = a2 + b2;
            //para cadeias de carateres, a soma funciona como uma junção das cadeias de caracteres.
            resultadoTextos = texto1 + texto2;


            Console.WriteLine("Soma:");
            Console.WriteLine("resultadoInt = " + resultadoInt);
            Console.WriteLine("resultadoDouble = " + resultadoDouble);
            Console.WriteLine("resultadoTextos = " + resultadoTextos);

            //subtração
            resultadoInt = a1 - b1;
            resultadoDouble = a2 - b2;

            Console.WriteLine("Subtração:");
            Console.WriteLine("resultadoInt = " + resultadoInt);
            Console.WriteLine("resultadoDouble = " + resultadoDouble);

            //divisão
            resultadoInt = a1 / b1;
            resultadoDouble = a2 / b2;

            Console.WriteLine("Divisão: ");
            Console.WriteLine("resultadoInt = " + resultadoInt);
            Console.WriteLine("resultadoDouble = " + resultadoDouble);

            //módulo
            resultadoInt = a1 % b1;
            Console.WriteLine("Módulo: ");
            Console.WriteLine("resultadoInt = " + resultadoInt);

            //para fazer operações mais complexas, usa-se os parênteses para indicar a ordem das operações:
            resultadoDouble = ((a2 / b2) * 100);
            Console.WriteLine("Operação complexa: "+ resultadoDouble);
        }
    }
}
