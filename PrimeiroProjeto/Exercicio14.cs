using System.Globalization;

namespace Exercicio14
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
    }

    class Program
    {
        static void Exercicio14(string[] args)
        {
            Console.WriteLine("Dados do primeiro funcionário:");
            Funcionario primeiroFuncionario, segundoFuncionario;

            primeiroFuncionario = new Funcionario();
            Console.Write($"Nome: ");
            primeiroFuncionario.Nome = Console.ReadLine();
            Console.Write($"Salário: ");
            primeiroFuncionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Nome: {primeiroFuncionario.Nome}");
            Console.WriteLine($"Salário: {primeiroFuncionario.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            segundoFuncionario = new Funcionario();
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write($"Nome ");
            segundoFuncionario.Nome = Console.ReadLine();
            Console.Write($"Salário: ");
            segundoFuncionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Nome: {segundoFuncionario.Nome}");
            Console.WriteLine($"Salário: {segundoFuncionario.Salario.ToString("F2")}");
            Console.WriteLine();

            double mediaSalarial = (primeiroFuncionario.Salario + segundoFuncionario.Salario) / 2.0;
            Console.WriteLine($"Media salarial: {mediaSalarial.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}