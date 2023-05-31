using DAL.Contracts;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SQL
{
    internal class SaleRepository : IGenericRepository<Sale>
    {
        public void Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetAll()
        {
            throw new NotImplementedException();
        }

        public Sale GetOne(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Sale obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid Id, Sale obj)
        {
            throw new NotImplementedException();
        }
    }
}
