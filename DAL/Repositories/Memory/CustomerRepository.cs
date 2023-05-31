using DAL.Contracts;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Memory
{
    internal class CustomerRepository : IGenericRepository<Customer>
    {
        public void Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetOne(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Customer obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid Id, Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
