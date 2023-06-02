using ConsoleApp.Dominio;
using ConsoleApp.Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Infraestructura.Factory
{
    public sealed class BoletoRepositoryFactory
    {
        private readonly static BoletoRepositoryFactory _instance = new BoletoRepositoryFactory();

        private string Backend;

        public static BoletoRepositoryFactory Current
        {
            get
            {
                return _instance;
            }
        }

        private BoletoRepositoryFactory()
        {
            //Implent here the initialization of your singleton
            Backend = ConfigurationManager.AppSettings["Backend"];
        }

        public IRepositorioBoleto GetBoletoRepository()
        {
            if (Backend == "Memory")
            {
                return new BoletoMemoryRepository();
            }
            else
            {
                return new BoletoSQLRepository();
            }
        }
    }
}
