using System;
using System.Collections.Generic;
using System.Globalization;

class ExercicioAlessandro
{
    static void ExercicioAlessandro2(string[] args)
    {
        Console.Write("Digite um número inteiro, positivo e que seja ímpar: ");
        string input = Console.ReadLine();
        int numeroUsuario;

        while (!int.TryParse(input, out numeroUsuario) || numeroUsuario <= 0 || numeroUsuario % 2 == 0)
        {
            if (numeroUsuario % 2 == 0 && numeroUsuario > 0)
            {
                Console.WriteLine();
                Console.Write("Você digitou um valor par. \nDigite um número inteiro, positivo e que seja ímpar: ");
            }
            else if (!int.TryParse(input, out numeroUsuario))
            {
                Console.WriteLine();
                Console.Write("Você digitou letras ao invés de números. \nDigite um número inteiro, positivo e que seja ímpar: ");
            }
            else if (numeroUsuario <= 0)
            {
                Console.WriteLine();
                Console.Write("Você digitou um valor negativo. \nDigite um número inteiro, positivo e que seja ímpar: ");
            }
            input = Console.ReadLine();
        }

        Console.WriteLine("_________________________________");

        int[] vetor = new int[numeroUsuario];
        bool sequenciaCorreta = true;
        Console.Write("Digite o primeiro número para ser o inicio da sequência: ");
        vetor[0] = int.Parse(Console.ReadLine());

        for (int i = 1; i < numeroUsuario; i++)
        {
            Console.WriteLine("_________________________________");
            Console.Write($"Insira o próximo número. \nDica, o próximo número deve ser {vetor[i - 1] + 1}: ");
            int numeroInserido = int.Parse(Console.ReadLine());

            if (numeroInserido != vetor[i - 1] + 1)
            {
                sequenciaCorreta = false;
                break;
            }
            vetor[i] = numeroInserido;
        }

        if (sequenciaCorreta)
        {
            Console.Write("Sequência correta! Os números inseridos são: ");
            foreach (int numero in vetor)
            {
                Console.Write(numero + ", ");
            }
        }
        else
        {
            Console.WriteLine("Sequência incorreta! O programa será encerrado.");
        }
    }
}