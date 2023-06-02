using ConsoleApp.Dominio;
using ConsoleApp.Infraestructura.Factory;
using ConsoleApp.Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Servicios
{
    public static class ServiceProvider
    {
        private static IRepositorioBoleto RepositorioBoleto = BoletoRepositoryFactory.Current.GetBoletoRepository();
        public static ServiceVenta ServiceVenta = new ServiceVenta(RepositorioBoleto);
    }
    
}
