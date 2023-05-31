using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Customer
    {
       public Guid Id { get; set; }
       public int Costo { get; set; }
       public DateTime Fecha_Regreso { get; set; }

    }
}

