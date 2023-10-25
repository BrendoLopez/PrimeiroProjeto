using PrimeiroProjeto;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão cadastrados? ");
            int quantidadeDeFuncionariosParaCadastrar = int.Parse(Console.ReadLine());
            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= quantidadeDeFuncionariosParaCadastrar; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Funcionário #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("Entre com o ID do funcionário que terá o salário aumentado: ");
            int entreComId = int.Parse(Console.ReadLine());

            Funcionario empregado = list.Find(x => x.Id == entreComId);

            if(entreComId != null)
            {
                Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empregado.IncrementarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("O ID do funcioário não existe");
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários:");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}