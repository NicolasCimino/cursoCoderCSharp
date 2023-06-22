using BLL.Contracts;
using DAL.Contracts;
using DAL.Factories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServicesBLL
{
    public sealed class ProductoVendidoServices : IGenericRepositoryBLL<ProductoVendido>
    {
        private readonly static ProductoVendidoServices _instance = new ProductoVendidoServices();

        public static ProductoVendidoServices Current
        {
            get
            {
                return _instance;
            }
        }

        private ProductoVendidoServices()
        {

        }

        IGenericRepository<ProductoVendido> productoVendidoRepository = Factory.Current.GetProductoVendidoRepository();
        public void Insert(ProductoVendido obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductoVendido obj)
        {
            throw new NotImplementedException();
        }

        public ProductoVendido GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductoVendido> GetAll()
        {
           return productoVendidoRepository.GetAll();
        }
    }
}
