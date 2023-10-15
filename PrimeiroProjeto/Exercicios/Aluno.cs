using PrimeiroProjeto;
using System.Globalization;

namespace PrimeiroProjeto
{
    public class Aluno
    {
        public string Nome;
        public double NotaPrimeiroTrimestre;
        public double NotaSegundoTrimestre;
        public double NotaTerceiroTrimestre;


        public double NotaFinal()
        {
            return NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiroTrimestre;
        }

        public bool Aprovacao()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovacao())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}

namespace curso
{
    class ExercicioAluno
    {
        static void Aluno(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do Aluno:");

            Console.Write("Nota primeiro trimestre: ");
            aluno.NotaPrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota segundo trimestre: ");
            aluno.NotaSegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota terceiro trimestre: ");
            aluno.NotaTerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovacao())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS.");
            }
        }
    }
}
