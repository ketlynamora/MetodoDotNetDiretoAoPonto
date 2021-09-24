using System;

namespace CsharpDiretoAoPontoHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Tipos de Dados

            int numeroInt = 10;

            int maiorNumeroInt = int.MaxValue;
            int menorNumeroInt = int.MinValue;

            long numeroLong = 131231654654;

            long maiorNumeroLong = long.MaxValue;
            long menorNumeroLong = long.MinValue;

            decimal numeroDecimal = 10.52m;

            double numeroDouble = 12.3;
            double maiorDouble = double.MaxValue;
            double menorDouble = double.MinValue;

            bool verdadeiro = true;
            bool falso = false;

            var numero = 10;

            string nome = "Ketlyn Dev";

            char letra = 'L';

            DateTime entradaEmpresa = new DateTime(2021, 1, 1);

            TimeSpan quantoTempoDeEmpresa = DateTime.Now - entradaEmpresa;


            #endregion

            #region Conversões

            int notaAluno = 10;

            // Conversão implicita
            double notaAlunoDouble = notaAluno;

            // Conversão explicita
            int numeroDoubleComoInt = (int)notaAlunoDouble;

            // Conversão utilizando Convert

            string notaString = "10";

            int notaConvert = Convert.ToInt32(notaString);

            // Conversão utilizando Parse

            int notaParse = int.Parse(notaString);

            if (!int.TryParse(notaString, out int notaTryParse))
            {
                Console.WriteLine("Número em formato inválido");
            }

            #endregion

            #region Operadores Aritméticos

            // Unários ++, --, + e -

            int numeroOperador = 4;

            Console.WriteLine(numeroOperador++); // 4
            Console.WriteLine(numeroOperador--); // 5

            Console.WriteLine(++numeroOperador); // 5
            Console.WriteLine(--numeroOperador); // 4

            Console.WriteLine(numeroOperador); // 4
            Console.WriteLine(-numeroOperador); // -4
            Console.WriteLine(-(-numeroOperador)); // 4


            // Binários * / + -

            var soma = 4 + 5;
            var subtracao = 4 - 5;
            var divisao = 20 / 3;
            var divisaoDouble = (double)20 / 3;

            var multiplos = (4 * 5) + 10;

            #endregion

            #region Operadores de Comparação > >= < <=

            Console.WriteLine(4 > 5); // FALSE
            Console.WriteLine(5 > 5); // FALSE
            Console.WriteLine(5 >= 5); // TRUE


            Console.WriteLine(5 < 5); // FALSE
            Console.WriteLine(5 <= 5); // TRUE
            Console.WriteLine(5 < 6); // TRUE


            #endregion

            #region Operadores de Igualdade ==, !=

            Console.WriteLine(5 == 5); // TRUE
            Console.WriteLine(5 == 4); // FALSE
             
            Console.WriteLine(5 != 5); // FALSE
            Console.WriteLine(5 != 4); // TRUE

            #endregion

            #region Operadores Lógicos AND && e OR ||

            var minhaNota = 7;
            var ultimoAno = true;

            if (minhaNota >= 7 && ultimoAno)
            {
                Console.WriteLine("Aprovado e terminou o curso, parabéns!");
            }

            minhaNota = 4;

            if (minhaNota >= 7 || ultimoAno)
            {
                Console.WriteLine("Aprovado, parabéns!");
            }

            Console.WriteLine(true || false); // TRUE
            Console.WriteLine(false || true); // TRUE
            Console.WriteLine(true || true); // TRUE
            Console.WriteLine(false || false); // FALSE

            Console.WriteLine(true && false); // FALSE
            Console.WriteLine(false && true); // FALSE
            Console.WriteLine(true && true); // TRUE
            Console.WriteLine(false && false); // FALSE


            #endregion

            Console.Read();
        }
    }
}
