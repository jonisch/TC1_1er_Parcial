using ConsoleApp.Dominio;
using ConsoleApp.Dominio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Servicios
{
    public class ServiceVenta
    {
        private IRepositorioBoleto Repositorio;
        public ServiceVenta(IRepositorioBoleto Repositorio)
        {
            this.Repositorio = Repositorio;
        }

        public Boleto VentaBoleto(DateTime FechaSalida, int TiempoEnDias, string TipoBoleto)
        {

            switch (TipoBoleto)
            {
                case "1":
                    return GetNewBoletoEjecutivo(FechaSalida, TiempoEnDias);

                case "2":
                    return GetNewBoletoTurista(FechaSalida, TiempoEnDias);

                default:
                    Console.WriteLine("Operación Incorrecta. Verificar!");
                    Console.ReadLine();
                    return null;
            }
        }

     

 

        public Boleto GetNewBoletoTurista(DateTime dateTime, int dias)
        {
            var Numero = Repositorio.ObtenerUltimoNumero();
            return new BoletoTurista(Numero, dateTime, dias);
        }

        public Boleto GetNewBoletoEjecutivo(DateTime dateTime, int dias)
        {
            var Numero = Repositorio.ObtenerUltimoNumero();
            return new BoletoEjecutivo(Numero, dateTime, dias);
        }

        public List<Boleto> ObtenerTodosLosBoletos()
        {
            return Repositorio.GetAll();
        }
    }
}
