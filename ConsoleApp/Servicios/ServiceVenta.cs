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

        public Boleto VentaBoleto(string FechaSalida, string TiempoEnDias, string TipoBoleto)
        {
            DateTime FSalida = ObtenerFechaSalida(FechaSalida);
            int Dias = ObtenerTiempoEnDias(TiempoEnDias);

            switch (TipoBoleto)
            {
                case "1":
                    return GetNewBoletoEjecutivo(FSalida, Dias);

                case "2":
                    return GetNewBoletoTurista(FSalida, Dias);

                default:
                    Console.WriteLine("Operación Incorrecta. Verificar!");
                    Console.ReadLine();
                    return null;
            }
        }

        private static int ObtenerTiempoEnDias(string TiempoEnDias)
        {
            int Dias;
            try
            {
                Dias = int.Parse(TiempoEnDias);
            }
            catch (Exception)
            {

                throw new NumeroInvalidoException("Número Inválido");
            }

            return Dias;
        }

        private static DateTime ObtenerFechaSalida(string FechaSalida)
        {
            DateTime FSalida;
            try
            {
                FSalida = DateTime.Parse(FechaSalida);

            }
            catch (Exception)
            {

                throw new FechaInvalidaException("Fecha Inválida");
            }

            return FSalida;
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
    }
}
