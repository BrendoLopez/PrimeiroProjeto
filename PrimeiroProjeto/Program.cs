﻿using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            int[] valores = { A, B, C };

            Array.Sort(valores);

            foreach (var vetores in valores)
            {
                Console.WriteLine(vetores);
            }

            Console.WriteLine(" ");
            Console.WriteLine($"{A}");
            Console.WriteLine($"{B}");
            Console.WriteLine($"{C}");
        }
    }
}