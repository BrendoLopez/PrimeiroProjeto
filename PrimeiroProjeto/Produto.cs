using PrimeiroProjeto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
    }
}

namespace curso
{
    class Exercicio1
    {
        static void Exercicio(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {produto.Nome}, $ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
            $"{produto.Quantidade} unidades," + " Total: $ " + produto.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");

            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados do produto: {produto.Nome}, $ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
            $"{produto.Quantidade} unidades," + " Total: $ " + produto.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados do produto: {produto.Nome}, $ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
            $"{produto.Quantidade} unidades," + " Total: $ " + produto.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
