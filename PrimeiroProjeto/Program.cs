﻿using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] mesmaLinha = Console.ReadLine().Split(' ');

            double[] vetor = new double[N];
            for (int i = 0; i < N; i++)
            {
                vetor[i] = double.Parse(mesmaLinha[i], CultureInfo.InvariantCulture);
            }

            double maiorNumero = vetor[0];
            double posicaoMaior = 0;

            for (int i = 1; i < N; i++)
            {
                if (vetor[i] > maiorNumero)
                {
                    maiorNumero = vetor[i];
                    posicaoMaior = i;
                }
            }
            Console.WriteLine(maiorNumero.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);
        }
    }
}