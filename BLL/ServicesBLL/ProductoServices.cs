using BLL.Contracts;
using Domain;
using DAL;
using DAL.Contracts;
using DAL.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL.ServicesBLL
{
    public sealed class ProductoServices : IGenericRepositoryBLL<Producto>
    {
        private readonly static ProductoServices _instance = new ProductoServices();

        public static ProductoServices Current
        {
            get
            {
                return _instance;
            }
        }

        private ProductoServices()
        {

        }

       
       


        IGenericRepository<Producto> productoRepository = Factory.Current.GetProductoRepository();


        public void Insert(Producto obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Producto obj)
        {
            throw new NotImplementedException();
        }

        public Producto GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> GetAll()
        {
            return productoRepository.GetAll();
        }
    }
}
