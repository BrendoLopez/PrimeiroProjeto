namespace PrimeiroProjeto.Entities;

public class ContaBancaria
{
    public int NumeroConta { get; set; }
    public string NomeTitular { get; set; }
    public decimal SaldoConta { get; set; }

    public ContaBancaria()
    {
    }

    public ContaBancaria(int numeroConta, string nomeTitular, decimal saldoConta)
    {
        NumeroConta = numeroConta;
        NomeTitular = nomeTitular;
        SaldoConta = saldoConta;
    }

    public void Depositar(decimal deposito)
    {
        SaldoConta += deposito;
    }

    public void Sacar(decimal saque)
    {
        if (saque > 0)
        {
            SaldoConta -= saque;
        }
        else
        {
            Console.WriteLine("Você não possui saldo na conta para sacar.");
        }
    }

    public override string ToString()
    {
        return $@"Nome do titular: {NomeTitular} 
        Número da conta: {NumeroConta} 
        Saldo da conta: {SaldoConta}";
    }

    //Console.Write("Qual o nome do titular da conta?: ");
    //    string titular = Console.ReadLine();

    //Console.Write("Qual o número da conta?: ");
    //    int numeroConta = int.Parse(Console.ReadLine());

    //decimal saldo = 0;

    //ContaBancaria conta = new ContaBancaria(numeroConta, titular, saldo);
    //Console.WriteLine($"Olá {conta.NomeTitular}, tudo bom? \nQual serviço o senhor(a) deseja realizar?");
}
