using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Dominio
{
    internal interface IRepositorioBoleto
    {
        void Insert(Boleto boleto);
        void Update(int Numero, Boleto boleto);
        void Delete(int Numero);
        List<Boleto> GetAll();
        Boleto GetOne(int Numero);
        Boleto GetNew();
    }
}
