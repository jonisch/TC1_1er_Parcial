using ConsoleApp.Dominio;
using ConsoleApp.Dominio.Excepciones;
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
            //Menu
            Console.WriteLine("#############################");
            Console.WriteLine("###### Venta de Boleto ######"); 
            Console.WriteLine("#############################");
            Console.WriteLine(" ");
            Console.WriteLine("Ingresar Fecha de Salida (dd/mm/aaaa)");
            var fechaSalida = Console.ReadLine();
            Console.WriteLine("Ingresar Dias (Tiempo en Días)");
            var TiempoEnDias = Console.ReadLine();







            Console.WriteLine("Seleccione el tipo de Voleto");
            Console.WriteLine("1) Boleto Ejecutivo");
            Console.WriteLine("2) Boleto Turista");
            var TipoBoleto = Console.ReadLine();
            var Service = ServiceProvider.ServiceVenta;
            var NuevoBoleto = Service.VentaBoleto(fechaSalida, TiempoEnDias, TipoBoleto);
           

            Console.WriteLine("Numero de Boleto:" + NuevoBoleto.Numero);
            Console.WriteLine("Fecha de Salda:" + NuevoBoleto.FechaSalida);
            Console.WriteLine("Fecha de Regreso:" + NuevoBoleto.CalcularRegreso());
            Console.WriteLine("Cantidad de días:" + NuevoBoleto.TiempoEnDias);
            Console.WriteLine("Costo Total:" + NuevoBoleto.CostoBoleto());

            Console.ReadLine();
            
        }

        
    }
}
