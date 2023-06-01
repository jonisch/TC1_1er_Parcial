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
            Console.WriteLine("Ingresar Fecha de Regreso (dd/mm/aaaa)");
            var fechaRegreso = Console.ReadLine();


                DateTime FSalida = DateTime.Parse(fechaSalida);
                DateTime FRegreso = DateTime.Parse(fechaRegreso);




            Console.WriteLine("Seleccione el tipo de Voleto");
            Console.WriteLine("1) Boleto Ejecutivo");
            Console.WriteLine("2) Boleto Turista");
            var Seleccion = Console.ReadLine();
            var Repository = ServiceProvider.RepositorioBoleto;
            Boleto NuevoBoleto = null;

            switch (Seleccion)
            {
                case "1":
                    NuevoBoleto = Repository.GetNewBoletoEjecutivo(FSalida);
                    break;
                case "2":
                    NuevoBoleto = Repository.GetNewBoletoTurista(FSalida);
                    break;
                default:
                    Console.WriteLine("Operación Incorrecta. Verificar!");
                    Console.ReadLine();
                    return;
            }
           
            NuevoBoleto.TiempoEnDias = (int)(FRegreso - FSalida).TotalDays;
            Console.WriteLine("Numero de Boleto:" + NuevoBoleto.Numero);
            Console.WriteLine("Fecha de Salda:" + NuevoBoleto.FechaSalida);
            Console.WriteLine("Fecha de Regreso:" + NuevoBoleto.CalcularRegreso());
            Console.WriteLine("Cantidad de días:" + NuevoBoleto.TiempoEnDias);
            Console.WriteLine("Costo Total:" + NuevoBoleto.CostoBoleto());

            Console.ReadLine();
            
        }

        
    }
}
