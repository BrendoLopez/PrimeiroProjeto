using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncrementarSalario(double porcentagem)
        {
            Salario = ((Salario * porcentagem) / 100) + Salario;
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Nome: " + Nome + ", Salário: " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

    namespace ExercicioFuncionario
    {
        class Exec
        {
            static void FuncionarioExercicio(string[] args)
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
                Console.WriteLine();
                Console.Write("Entre com o ID do funcionário que terá o salário aumentado: ");
                int entreComId = int.Parse(Console.ReadLine());

                Funcionario empregado = list.Find(x => x.Id == entreComId);

                if (empregado != null)
                {
                    Console.Write("Digite a porcentagem: ");
                    double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    empregado.IncrementarSalario(porcentagem);
                }
                else
                {
                    Console.WriteLine("O ID do funcionário não existe");
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
}
