﻿using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int X;
            int[] vet;
            vet = new int[N];
            string[] S = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(S[i]);
            }
            //for (int i = 0; i < 1; i++)
            //{
            //    X = int.Parse(Console.ReadLine());
            //    vet[i] = X;
            //}
            for (int i = 0; i < N; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}