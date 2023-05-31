using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    interface IGenericRepository <T>
    {
        void Insert(T obj);
        void Update(Guid Id, T obj);
        void Delete(Guid Id);
        List<T> GetAll();
        T GetOne(Guid Id);
    }
}
