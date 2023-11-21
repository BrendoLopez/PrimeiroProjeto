using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercicios
{
    internal class NumeroPerfeito
    {
        class Program
        {
            static void Exercicio(string[] args)
            {
                //Escreva um programa em C# que solicite ao usuário um número inteiro e determine se esse número é um número perfeito. 
                //Um número perfeito é aquele cuja soma dos seus divisores próprios (excluindo ele mesmo) é igual ao próprio número.
                //Por exemplo, o número 28 é perfeito porque os seus divisores próprios são 1, 2, 4, 7, e a soma deles é 1 + 2 + 4 + 7 = 14, que é igual a 28.

                Console.Write("Digite um número inteiro perfeito: ");
                string input = Console.ReadLine();
                int numberPerfect;

                while (!int.TryParse(input, out numberPerfect) || numberPerfect <= 0)
                {
                    Console.WriteLine();
                    Console.Write("Você digitou algo inválido. \nDigite um número inteiro perfeito: ");
                    input = Console.ReadLine();
                }

                int somaDivisores = 0;

                for (int i = 1; i <= numberPerfect / 2; i++)
                {
                    if (numberPerfect % i == 0)
                    {
                        somaDivisores += i;
                    }
                }

                if (somaDivisores == numberPerfect)
                {
                    Console.WriteLine($"{numberPerfect} é um número perfeito!");
                }
                else
                {
                    Console.WriteLine($"{numberPerfect} não é um número perfeito.");
                }

            }
        }
    }
}
