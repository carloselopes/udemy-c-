﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }
        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Categoria.nome
                + ", "
                + Categoria.nivel;
        }
    }
}
