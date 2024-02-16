using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaPetShop
{
    internal class Produto
    {
        public int CodProduto { get; set; }

        public required string NomeProduto { get; set; }

        public int TipoProduto { get; set; }

        public decimal ValorCompra { get; set; }

        public decimal ValorVenda { get; set; }

        public int Status { get; set; }

    }
}
