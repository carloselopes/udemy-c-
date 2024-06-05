using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Course2
{
    internal class Produto
    {
        public int codigoProduto { get; private set; }
        public string descricaoProduto { get; private set; }
        public double quantidadeProduto { get; private set; }
        public double precoProduto { get; private set; }


        public Produto(int codigo, string descricao, double quantidade, double preco)
        {
            this.codigoProduto = codigo;
            this.descricaoProduto = descricao;
            this.quantidadeProduto = quantidade;
            this.precoProduto = preco; 
        }
        public override string ToString()
        {
            return codigoProduto
                + ", " + descricaoProduto
                + ", " + quantidadeProduto
                + " unidades"
                + ", R$ " + precoProduto
                + ", R$ " + ValorTotalDoProduto();
        }
        public void AlterarDescricaoDoProduto(string descricao)
        {
            descricaoProduto = descricao;
        }
        public void AumentarPrecoDoProduto(double preco)
        {
            precoProduto = preco;
        }
        public void DiminuirValorDoProduto(double valor)
        {
            precoProduto -= valor;
        }
        public void AumentarQuantidadeEmEstoque(double valor)
        {
            quantidadeProduto += valor;
        }
        public void DiminuirQuantidadeEmEstoque(double valor)
        {
            quantidadeProduto -= valor;
        }
        public double ValorTotalDoProduto()
        {
            return quantidadeProduto * precoProduto;
        }
    }
}
