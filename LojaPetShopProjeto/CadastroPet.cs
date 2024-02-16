using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LojaPetShop
{
    public class CadastroPet
    {

        public int CodCadastro { get; set; }

        public required string NomePet { get; set; }
            
        public int TipoPet { get; set; }
        public int RacaPet { get; set; }
        public int TamanhoPelo { get; set; }
        public int PorteAnimal { get; set; }
        public int Cor { get; set; }
        public int Sexo { get; set; }        
        public bool Castrado { get; set; }
        public decimal Peso { get; set; }
        public  string? ObsPet { get; set; }
        public int Status { get; set; }
    }

    public class RacasPet
    {
        public int CodRaca { get; set; }        
        public int CodTipoPet { get; set; }
        public required string NomeRaca { get; set; }
        public int Status { get; set; }
    }

    public class TipoPet
    {
        public int CodTipoPet { get; set; }
        public required string NomeTipo { get; set; }
        public int Status { get; set; }
    }
}
