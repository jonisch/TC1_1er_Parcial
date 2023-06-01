using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Dominio
{
    internal class BoletoEjecutivo : Boleto
    {
        private int ValorBoletoEjecutivo = 9800;

        public BoletoEjecutivo(int Numero, DateTime dateTime) : base(Numero, dateTime)
        {
        }

        public override double CostoBoleto()=> base.CostoEmbarque + ValorBoletoEjecutivo;
       
    }
}
