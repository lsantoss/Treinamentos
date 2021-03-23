using System;

namespace _05Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 -> 255
            byte variavelByte = 5;

            // -128 -> 127
            sbyte variavelSByte = 55;

            // -32768 -> 32767
            short variavelShort = 5;

            // 0 -> 65535
            ushort variavelUShort = 895;
            
            // -2147483648 -> 2147483647
            int variavelInt = 754;

            // 0 -> 4294967295
            uint variavelUInt = 412;

            // -9223372036854775808 -> 9223372036854775807
            long variavelLong = 455;

            // 0 -> 18446744073709551615
            ulong variavelULong = 969;

            // -3.40282347E+38F -> 3.40282347E+38F
            float nomeVariavelFloat = 6.33f;

            // -1.7976931348623157E+308 -> 1.7976931348623157E+308
            double nomeVariavelDouble = 52.60;

            // -79228162514264337593543950335M -> 79228162514264337593543950335M
            decimal nomeVariavelDecimal = 785.74m;

            // true ou false
            bool verdadeiro = true;

            // true ou false
            bool falso = false;

            // somente 1 caracter entre aspas simples
            char caracter = 'F';

            Console.WriteLine(variavelByte);
            Console.WriteLine(variavelSByte);

            Console.WriteLine(variavelShort);
            Console.WriteLine(variavelUShort);

            Console.WriteLine(variavelInt);
            Console.WriteLine(variavelUInt);

            Console.WriteLine(variavelLong);
            Console.WriteLine(variavelULong);

            Console.WriteLine(nomeVariavelFloat);
            Console.WriteLine(nomeVariavelDouble);
            Console.WriteLine(nomeVariavelDecimal);

            Console.WriteLine(verdadeiro);
            Console.WriteLine(falso);

            Console.WriteLine(caracter);

            Console.ReadKey();
        }
    }
}