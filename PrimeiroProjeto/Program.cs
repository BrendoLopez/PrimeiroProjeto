﻿using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaAluno1 = -1;
            double notaAluno2 = -1;

            while (true)
            {
                notaAluno1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (notaAluno1 >= 0 && notaAluno1 <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }
            while (true)
            {
                notaAluno2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (notaAluno2 >= 0 && notaAluno2 <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }
            double somaMedia = (notaAluno1 + notaAluno2) / 2;
            Console.WriteLine("media = " + somaMedia.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}