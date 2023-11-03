using PrimeiroProjeto.Entities;
using System.Globalization;

namespace curso;

class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        funcionario.CalcularReajuste(salario);
    }
}