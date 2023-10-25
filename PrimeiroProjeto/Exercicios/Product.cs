using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProduct
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class ExercicioVetor
    {
        static void VetorComObjeto(string[] args)
        {
            int quantidadeDeProdutos = int.Parse(Console.ReadLine());

            Product[] vect = new Product[quantidadeDeProdutos];

            for (int i = 0; i < quantidadeDeProdutos; i++)
            {
                string nameProduto = Console.ReadLine();
                double valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = nameProduto, Price = valorProduto };
            }

            double somaValorProdutos = 0.0;

            for (int i = 0; i < quantidadeDeProdutos; i++)
            {
                somaValorProdutos += vect[i].Price;
            }
            Console.WriteLine(somaValorProdutos / quantidadeDeProdutos);
        }
    }
}
