using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaPetShop
{
    internal class Caixa
    {
        public int CaixaRegistro { get; set; }

        public int CodFuncionario { get; set; }

        public int CodProdServico { get; set; }

        public int CodFormaPgto { get; set; }

        public decimal ValorFinal { get; set; }
        public decimal ValorDesconto { get; set; }
        public DateTime DthrVenda { get; set; }


        public int PagtoPendente { get; set; }

    }
}
