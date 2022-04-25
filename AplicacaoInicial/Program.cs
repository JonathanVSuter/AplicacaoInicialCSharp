using System;

namespace TiposPrimitivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //recebe um tipo verdadeiro ou falso (true ou false)
            bool v_bool = true;
            //recebe um valor inteiro entre 0 e 255
            byte v_bytes = 123;
            //recebe um valor inteiro entre -128 e 127
            sbyte v_sbytes = 127;
            //recebe um valor inteiro entre -32768 e 32767
            short v_short = 32767;
            //recebe um valor inteiro entre 0 e 65535
            ushort v_ushort = 62535;
            //recebe um valor inteiro entre -2147483648 e 2147483647
            int v_int = 2147483647;
            //recebe um valor inteiro entre 0 e 4294967295
            uint v_uint = 4294967295;
            //recebe um valor entre -9223372036854775808 e 9223372036854775807
            long v_long = 9223372036854775807;
            //recebe um valor inteiro entre 0 e 18446744073709551615
            ulong v_ulong = 18446744073709551615;
            //recebe um valor real com precisão de 7 dígitos
            float v_float = 3.1415926f;
            //recebe um valor real com precisão de até 16 dígitos.
            double v_double = 3.14159265359;
            //recebe um valor real com precisão de até 29 dígitos. 
            decimal v_decimal = 4.00000000000000000000000000000M;
            //recebe um tipo de texto de apenas um caractere.
            char v_char = 'A';            
            //recebe um tipo do enumerador
            EnumeradorTeste situacao = EnumeradorTeste.A;
            //é possível converter o enumerador para um número inteiro:
            int situacao_int = (int)EnumeradorTeste.A;
            //recebe uma cadeia de caracteres
            string v_string = "Jonathan Vinícius Suter";
                        


        }
        enum EnumeradorTeste
        {
            A,
            B,
            C
        }
    }    
}
