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

            try
            {
                Console.WriteLine("Ingresar Fecha de Salida (dd/mm/aaaa)");
                var fechaSalida = ObtenerFechaSalida();
                Console.WriteLine(" ");
                Console.WriteLine("Ingresar Dias (Tiempo en Días)");
                var TiempoEnDias = ObtenerTiempoEnDias();
                Console.WriteLine(" ");
                Console.WriteLine("Seleccione el tipo de Voleto");
                Console.WriteLine("1) Boleto Ejecutivo");
                Console.WriteLine("2) Boleto Turista");
                var TipoBoleto = Console.ReadLine();
                var Service = ServiceProvider.ServiceVenta;
                var NuevoBoleto = Service.VentaBoleto(fechaSalida, TiempoEnDias, TipoBoleto);
                Console.WriteLine(" ");
                Console.WriteLine("## Resumen de la Operación Realizada ##");
                Console.WriteLine("Numero de Boleto:" + NuevoBoleto.Numero);
                Console.WriteLine("Fecha de Salda:" + NuevoBoleto.FechaSalida);
                Console.WriteLine("Fecha de Regreso:" + NuevoBoleto.CalcularRegreso());
                Console.WriteLine("Cantidad de días:" + NuevoBoleto.TiempoEnDias);
                Console.WriteLine("Costo Total $:" + NuevoBoleto.CostoBoleto());

                //List<Boleto> ListaBoletos = Service.ObtenerTodosLosBoletos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.ReadLine();
            
        }

        private static DateTime ObtenerFechaSalida()
        {
            try
            {
                return DateTime.Parse(Console.ReadLine());

            }
            catch (Exception)
            {

                throw new FechaInvalidaException("Fecha Inválida");
            }

        }

        private static int ObtenerTiempoEnDias()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                throw new NumeroInvalidoException("Número Inválido");
            }
        }

    }
}
