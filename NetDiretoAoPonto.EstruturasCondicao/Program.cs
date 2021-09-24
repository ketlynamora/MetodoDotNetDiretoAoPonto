using System;

namespace NetDiretoAoPonto.EstruturasCondicao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Estruturas de Condição if/else

            //Console.Write("Digite uma nota entre 0 e 100: ");
            //var notaDigitada = Console.ReadLine();

            //var nota = int.Parse(notaDigitada);

            //if (nota >= 70)
            //{
            //    Console.WriteLine("APROVADO!");
            //} else if (nota >= 40)
            //{
            //    Console.WriteLine("RECUPERAÇÃO!");
            //} else
            //{
            //    Console.WriteLine("REPROVADO");
            //}

            #endregion

            #region Estruturas de Condição switch/case

            Console.WriteLine("Seja bem-vindo a empresa X! ");

            Console.WriteLine("Digite 1 - Contratação de plano");
            Console.WriteLine("Digite 2 - Reclamação de serviço prestado");
            Console.WriteLine("Digite 3 - Segunda via de boleto");
            Console.WriteLine("Digite 4 - Sair");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Informações de plano novo");
                    break;
                case "2":
                    Console.WriteLine("Fale sobre sua reclamação");
                    break;
                case "3":
                    Console.WriteLine("Segunda via de boleto enviada por e-mail");
                    break;
                case "4":
                    Console.WriteLine("Tenha um bom dia!");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada, tente novamente");
                    break;
            }

            #endregion

        }
    }
}
