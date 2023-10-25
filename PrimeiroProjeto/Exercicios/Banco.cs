using PrimeiroProjeto;
using System.Globalization;

namespace PrimeiroProjeto
{
    public class Banco
    {
        private int _numeroConta;
        private string _nomeTitular;
        private double _saldoInicial;

        public int NumeroConta
        {
            get{ return _numeroConta; }
            set{ _numeroConta = value; }
        }
        public string NomeTitular
        {
            get{ return _nomeTitular; }
            set{ _nomeTitular = value; }
        }
        public double SaldoInicial
        {
            get{ return _saldoInicial; }
            set{ _saldoInicial = value; }
        }

        public bool InserirSaldoInicial(string resposta)
        {
            if (resposta == "s")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double ValorDeposito(double deposito)
        {
            return SaldoInicial = SaldoInicial + deposito;
        }        
        
        public double ValorSaque(double saque)
        {
            return SaldoInicial = SaldoInicial - saque - 5;
        }

        public override string ToString()
        {
            return "Conta: " 
                + _numeroConta 
                + ", Titular: " 
                + _nomeTitular 
                + ", Saldo: $ " 
                + _saldoInicial.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

namespace curso
{
    class ExercicioBanco
    {
        static void ExercicioContaBancaria(string[] args)
        {
            Banco pessoa = new Banco();

            Console.Write("Entre com o número da conta: ");
            pessoa.NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            pessoa.NomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            bool respostaSimOuNao = pessoa.InserirSaldoInicial(Console.ReadLine());


            if (respostaSimOuNao == true)
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                pessoa.SaldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(pessoa);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(pessoa);
            }
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            pessoa.ValorDeposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(pessoa);

            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            pessoa.ValorSaque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(pessoa);

            Console.WriteLine();
        }
    }
}
