using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] codigoLinhaUm = Console.ReadLine().Split(' ');
            string[] codigoLinhaDois = Console.ReadLine().Split(' ');

            int codigoPecaUm = int.Parse(codigoLinhaUm[0]);
            int quantidadeUm = int.Parse(codigoLinhaUm[1]);
            double valorUnitarioUm = double.Parse(codigoLinhaUm[2], CultureInfo.InvariantCulture);

            int codigoPecaDois = int.Parse(codigoLinhaDois[0]);
            int quantidadeDois = int.Parse(codigoLinhaDois[1]);
            double valorUnitarioDois = double.Parse(codigoLinhaDois[2], CultureInfo.InvariantCulture);

            double valorPagar = (quantidadeUm * valorUnitarioUm) + (quantidadeDois * valorUnitarioDois);
            Console.WriteLine("VALOR A PAGAR: R$ " + valorPagar.ToString("F2").Replace(",","."), CultureInfo.InvariantCulture);
        }
    }
}