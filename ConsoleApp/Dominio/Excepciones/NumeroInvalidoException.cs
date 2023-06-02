using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Dominio.Excepciones
{
    public class NumeroInvalidoException:Exception
    {
        public NumeroInvalidoException(string Mensaje):base(Mensaje)
        {
               
        }
    }
}
