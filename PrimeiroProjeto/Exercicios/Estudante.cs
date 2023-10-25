using PrimeiroProjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Estudante
    {
        public string Nome{ get; set; }
        public string Email{ get; set; }

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return "Nome: "+ Nome + ", " + "Email: "+ Email;
        }
    }
}

namespace ExercicioEstudante
{
    class EstudanteExercicio
    {
        static void ExercicioEstudant(string[] args)
        {
            Estudante[] vetor = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");

            int numeroDeEstudantes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroDeEstudantes; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine(i + ": " + vetor[i]);
                }
            }
        }
    }
}
