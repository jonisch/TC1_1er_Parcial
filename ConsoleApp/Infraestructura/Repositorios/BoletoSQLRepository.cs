using ConsoleApp.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Infraestructura.Repositorios
{
    internal class BoletoSQLRepository : IRepositorioBoleto
    {
        public void Delete(int Numero)
        {
            throw new NotImplementedException();
        }

        public List<Boleto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Boleto GetNewBoletoEjecutivo(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public Boleto GetNewBoletoTurista(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public Boleto GetOne(int Numero)
        {
            throw new NotImplementedException();
        }

        public void Insert(Boleto boleto)
        {
            throw new NotImplementedException();
        }

        public void Update(int Numero, Boleto boleto)
        {
            throw new NotImplementedException();
        }
    }
}
