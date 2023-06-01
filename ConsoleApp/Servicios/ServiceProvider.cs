using ConsoleApp.Dominio;
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
        public static IRepositorioBoleto RepositorioBoleto= new BoletoMemoryRepository();

    }
}
