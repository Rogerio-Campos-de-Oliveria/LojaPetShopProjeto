using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaPetShop
{
    internal class CadastroFuncionario
    {
        public int CodFuncionario { get; set; }
        public required string NomeFuncionario { get; set; }
        public int Status { get; set; }
        public int CPFouCNPJ { get; set; }
        public int CepCod { get; set; }
        public required string Endereço { get; set; }
        public int NumeroCasa { get; set; }
        public int Complemento { get; set; }
        public required string Bairro { get; set; }
        public int Cidade { get; set; }
        public int CelularNum { get; set; }
        public required string EmailUsuario { get; set; }
    }
}
