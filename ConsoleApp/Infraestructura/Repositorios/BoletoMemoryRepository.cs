using ConsoleApp.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Infraestructura.Repositorios
{
    internal class BoletoMemoryRepository : IRepositorioBoleto
    {
        private List<Boleto> boletos=new List<Boleto>();
        public void Delete(int Numero)
        {
            var boleto=GetOne(Numero);
            if (boleto==null)
                return;
            boletos.Remove(boleto);
            
        }

        public List<Boleto> GetAll()
        {
            return boletos;
        }


        public Boleto GetOne(int Numero)
        {
            return boletos.Find(x => x.Numero==Numero);
        }

        public void Insert(Boleto boleto)
        {
            boletos.Add(boleto);
        }

        public void Update(int Numero, Boleto boleto)
        {
            //al ser persistido en memoria no se va a actualizar
        }

        int IRepositorioBoleto.ObtenerUltimoNumero()
        {
            var mayor = 0;
            foreach (var boleto in boletos)
            {
                if (boleto.Numero > mayor)
                    mayor = boleto.Numero;
            }
            return mayor + 1;
        }
    }
}
