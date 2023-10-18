using PrimeiroProjeto;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco pessoa = new Banco();
            Console.WriteLine("Entre com o número da conta: ");

            string nomeTitular = Console.ReadLine();
            pessoa.SetNomeTitular(nomeTitular);
            Console.WriteLine(nomeTitular);

        }
    }
}