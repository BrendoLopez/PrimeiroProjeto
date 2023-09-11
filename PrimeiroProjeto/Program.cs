using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double idadeUsuario, soma, media;
            int contagem;
            idadeUsuario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = 0.0;
            contagem = 0;
            while (idadeUsuario >= 0)
            {
                soma = soma + idadeUsuario;
                contagem++;
                idadeUsuario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (contagem == 0)
            {
                Console.WriteLine("Impossivel calcular");
            } else
            {
                media = soma / contagem;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}