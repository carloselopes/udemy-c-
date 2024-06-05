using Course2;
using System;
using System.Globalization;

namespace Course2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Informe os dados do produto a ser cadastrado");
            Console.Write("Descrição do produto: ");
            //int codigo = int.Parse(Console.ReadLine()) + 1;
            string descricao = Console.ReadLine();
            while (descricao.Length < 1 || descricao == null)
            { 
                if (descricao.Length !< 1 || descricao == null)
                {
                    Console.WriteLine("Descricao do produto incorreto! Favor preencher corretamente!");
                }
            }
            Console.Write("Quantidade do produto: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto p = new Produto(descricao, quantidade, preco);

            Console.WriteLine("");
            Console.WriteLine("Dados do produto: " + p);
        }
    }
}