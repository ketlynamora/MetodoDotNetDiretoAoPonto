using System;

namespace NetDiretoAoPonto.TratandoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tratando Exceções

            var seteString = "sete";
            string valorNull = null;
            var longValue = long.MaxValue.ToString();

            try
            {
                var formatException = int.Parse(seteString);
                var argumentNullException = int.Parse(valorNull);
                var overflowException = int.Parse(longValue);
            }
            catch (FormatException exception)
            {
                Console.WriteLine($"Format Exception: {exception.Message}");
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine($"Argument Null Exception: {exception.Message}");
            }
            catch (OverflowException exception)
            {
                Console.WriteLine($"Overflow Exception: {exception.Message}");
            }
            finally
            {
                Console.WriteLine($"Esse código é executado sempre! ");
            }

            #endregion
        }
    }
}
