using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Dominio
{
    public abstract class Boleto
    {
        public double CostoEmbarque { get; set; }
        public  DateTime FechaSalida{ get; }
        public int Numero { get; }
        public int TiempoEnDias { get; set; }


        public Boleto(int Numero, DateTime dateTime)
        {
            this.Numero = Numero;
            this.CostoEmbarque = 9950;
            this.FechaSalida = dateTime;
        }

        public DateTime CalcularRegreso() => FechaSalida.AddDays(TiempoEnDias);

        public abstract double CostoBoleto();
    }
}
