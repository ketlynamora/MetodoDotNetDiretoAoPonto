using System;

namespace NetDiretoAoPonto.TrabalhandoComStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Principais Métodos, Campo e Propriedade

            var paragrafo = "     C# é uma linguagem moderna e versátil. " +
                "Com C# consigo desenvolver para Web, Desktop, Jogos, " +
                "Mobile, entre outros        ";

            // Length

            var tamanho = paragrafo.Length;

            // Empty

            var vazio = string.Empty;

            // ToLower, ToUpper

            var paragrafoMinusculo = paragrafo.ToLower();
            var paragrafoMaiuscula = paragrafo.ToUpper();

            // Split

            var frases = paragrafo.Split('.');

            // Trim, TrimEnd, TrimStart

            var paragrafoTrim = paragrafo.Trim();
            var paragrafoTrimEnd = paragrafo.TrimEnd();
            var paragrafoTrimStart = paragrafo.TrimStart();

            // IsNullOrWhiteSpace

            var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(paragrafo);

            // Replace

            var paragrafoCsharp = paragrafo.Replace("C#", "C-sharp");

            #endregion

            #region Busca

            var outroParagrafo = "C# é uma linguagem moderna e versátil. " +
                "Com C# consigo desenvolver para Web, Desktop, Jogos, " +
                "Mobile, entre outros";

            // IndexOf

            var indexOf = outroParagrafo.IndexOf("C#");
            
            // LastIndexOf 

            var lastIndexOf = outroParagrafo.LastIndexOf("C#");

            // StartsWith 

            var startsWith = outroParagrafo.StartsWith("C#");

            // Substring 

            var indexOfMobile = outroParagrafo.IndexOf("Mobile");
            var substringMobile = outroParagrafo.Substring(indexOfMobile, 6);

            // Contains 

            var contains = outroParagrafo.Contains("jogos", StringComparison.OrdinalIgnoreCase);
            var containsJogosExact = outroParagrafo.Contains("Jogos");
            var containsRuim = outroParagrafo.Contains("ruim");

            #endregion

            Console.ReadKey();
        }
    }
}
