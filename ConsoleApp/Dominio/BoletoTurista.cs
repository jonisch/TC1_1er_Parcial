using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Dominio
{
    internal class BoletoTurista: Boleto
    {
        private int ValorBoletoTurista = 8400;

        public BoletoTurista(int Numero) : base(Numero)
        {
        }

        internal override double CostoBoleto() => base.CostoEmbarque + ValorBoletoTurista;
    }
}
