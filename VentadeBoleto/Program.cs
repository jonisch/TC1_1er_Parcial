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
            Console.WriteLine("Seleccione el tipo de Voleto");
            Console.WriteLine("1) Boleto Ejecutivo");
            Console.WriteLine("2) Boleto Turista");
            var Seleccion = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Ingresar Dia de Salida");
            var Dia = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Ingresar Mes de Salida");
            var Mes = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Ingresar Día de Regreso");
            var DRegreso = Console.ReadLine();
            Console.WriteLine(" ");
            string Salida = Dia+"/"+Mes+"/"+DateTime.Now.Year;
            DateTime FSalida = DateTime.Parse(Salida);
            int ResultDia = Int32.Parse(Dia);
            int ResultDRegreso = Int32.Parse(DRegreso);
            //Menu

           // Console.WriteLine("Ingresar Cantidad de Boletos");
           // var Cantidad = Console.ReadLine();
           // int ResultCantidad = Int32.Parse(Cantidad);

            var Repository = ServiceProvider.RepositorioBoleto;
           
            if (Seleccion == "1")
            {
                var NuevoBoletoEjecutivo = Repository.GetNewBoletoEjecutivo(FSalida);
                NuevoBoletoEjecutivo.TiempoEnDias = ResultDRegreso-ResultDia;
                Console.WriteLine("Numero de Boleto:" + NuevoBoletoEjecutivo.Numero);
                Console.WriteLine("Fecha de Salda:" + NuevoBoletoEjecutivo.FechaSalida);
                Console.WriteLine("Fecha de Regreso:" + NuevoBoletoEjecutivo.CalcularRegreso());
                Console.WriteLine("Costo Total:" + NuevoBoletoEjecutivo.CostoBoleto());
            };

            if (Seleccion == "2")
            {
                var NuevoBoletoTurista = Repository.GetNewBoletoTurista(FSalida);
                NuevoBoletoTurista.TiempoEnDias = ResultDRegreso - ResultDia;
                Console.WriteLine("Numero de Boleto:" + NuevoBoletoTurista.Numero);
                Console.WriteLine("Fecha de Salda:" + NuevoBoletoTurista.FechaSalida);
                Console.WriteLine("Fecha de Regreso:" + NuevoBoletoTurista.CalcularRegreso());
                Console.WriteLine("Costo Total:" + NuevoBoletoTurista.CostoBoleto());
            };


            Console.ReadLine();
            
        }

        
    }
}
