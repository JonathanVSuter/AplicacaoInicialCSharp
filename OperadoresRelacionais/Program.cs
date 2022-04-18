using System;

namespace OperadoresRelacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 100, b1 = 50;            
            string texto1 = "Jonathan", texto2 = "Jonathan";            
            bool resultadoInt, resultadoString;

            //maior que
            resultadoInt = a1 > b1;
            Console.WriteLine("ResultadoInt: " + resultadoInt);

            //menor que
            resultadoInt = a1 >= b1;
            Console.WriteLine("ResultadoInt: " + resultadoInt);

            //menor ou igual que
            resultadoInt = a1 <= b1;
            Console.WriteLine("ResultadoInt: " + resultadoInt);
            
            //menor que
            resultadoInt = a1 < b1;
            Console.WriteLine("ResultadoInt: " + resultadoInt);

            //Igualdade
            resultadoInt = a1 == b1;
            Console.WriteLine("ResultadoInt: " + resultadoInt);

            //Diferença
            resultadoInt = a1 != b1;
            Console.WriteLine("ResultadoInt: " + resultadoInt);

            //Comparando strings
            resultadoString = texto1 == texto2;
            Console.WriteLine("ResultadoInt: " + resultadoString);        
        }
    }
}
