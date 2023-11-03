using System.Globalization;

namespace PrimeiroProjeto.Entities;

public class Funcionario
{
    public void CalcularReajuste(double salario)
    {
        double novoSalario = 0.0;
        double valorReajuste = 0.0;
        double percentualReajuste = 0.0;
        
        if (salario <= 400.00)
        {
            percentualReajuste = 15.0;
        }
        else if (salario <= 800.00)
        {
            percentualReajuste = 12.0;
        }
        else if (salario <= 1200.00)
        {
            percentualReajuste = 10.0;
        }
        else if (salario <= 2000.00)
        {
            percentualReajuste = 7.0;
        }
        else
        {
            percentualReajuste = 4.0;
        }

        valorReajuste = (salario * percentualReajuste) / 100;
        novoSalario = salario + valorReajuste;

        Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: " + valorReajuste.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: " + percentualReajuste.ToString("F0") + " %");
    }
}
