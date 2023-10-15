using System.Globalization;

namespace PrimeiroProjeto
{
    public static class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double cotacao, double quantia)
        {
            double total = cotacao * quantia;
            return total + total * Iof / 100.0;
        }
    }

    namespace curso
    {
        class Estaticos
        {
            static void ExercicioMembrosEstaticos(string[] args)
            {
                Console.Write("Qual é a cotação do dólar? ");
                double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantos dólares você vai comprar? ");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado = ConversorDeMoeda.DolarParaReal(cotacao, quantia);
                Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
