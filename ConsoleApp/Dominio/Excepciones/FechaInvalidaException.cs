using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Dominio.Excepciones
{
    public class FechaInvalidaException: Exception
    {
        public FechaInvalidaException(string Mensaje):base(Mensaje)
        {
            
        }
    }
}
