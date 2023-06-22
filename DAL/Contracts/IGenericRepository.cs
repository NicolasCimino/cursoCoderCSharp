using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IGenericRepository<T>
    {
        void Insert(T obj);

        void Delete(int id);

        void Update(T obj);

        T GetOne(int id);

        IEnumerable<T> GetAll();
    }
}
