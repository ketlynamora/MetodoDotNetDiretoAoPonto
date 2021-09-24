using System;

namespace NetDiretoAoPonto.EstruturasRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Estrutura de Repetição - for

            Console.WriteLine("Digite uma sequência de números separados por espaço: ");
            // 0 1 2 3 4 5 6 7 8 9 10

            var numerosTexto = Console.ReadLine();

            var numeros = numerosTexto.Split(' ');

            Console.WriteLine("Números: ");

            Console.WriteLine("USANDO FOR");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            #endregion

            #region Estrutura de Repetição - while

            Console.WriteLine("USANDO WHILE");

            var contador = 0;

            while (contador < numeros.Length)
            {
                Console.WriteLine(numeros[contador]);
                contador++;
            }

            #endregion

            #region Estrutura de Repetição - foreach

            Console.WriteLine("USANDO FOREACH");

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            #endregion

            Console.ReadKey();
        }
    }
}
