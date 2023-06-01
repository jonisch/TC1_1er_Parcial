using ConsoleApp.Servicios;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentadeBoleto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Repository = ServiceProvider.RepositorioBoleto;
            var NuevoBoleto = Repository.GetNewBoletoEjecutivo(DateTime.Now.AddDays(10)); //Fecha de Salida
            NuevoBoleto.TiempoEnDias = 7;
            Console.WriteLine("Numero de Boleto:" + NuevoBoleto.Numero);
            Console.WriteLine("Fecha de Salda:" + NuevoBoleto.FechaSalida);
            Console.WriteLine("Fecha de Regreso:" + NuevoBoleto.CalcularRegreso());
            Console.WriteLine("Costo Total:" + NuevoBoleto.CostoBoleto());
            //Console.ReadLine();
            var Seleccion = Console.ReadLine();
            if (Seleccion == "1")
            {

            }
        }

        //string s = "2011-03-21 13:26";

        //DateTime dt =
        //    DateTime.ParseExact(s, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
    }
}
