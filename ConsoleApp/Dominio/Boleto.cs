using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Dominio
{
    internal abstract class Boleto
    {
        public double CostoEmbarque { get; set; }
        public  DateTime FechaSalida{ get; set; }
        public int Numero { get; }
        public int TiempoEnDias { get; set; }


        public Boleto(int Numero)
        {
            this.Numero = Numero;
            this.CostoEmbarque = 9950;
        }

        internal DateTime CalcularRegreso() => FechaSalida.AddDays(TiempoEnDias);

        internal abstract double CostoBoleto();
    }
}
