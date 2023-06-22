using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factories
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Factory
    {

        private readonly static Factory _instance = new Factory();

        public static Factory Current
        {
            get
            {
                return _instance;
            }
        }

        private Factory()
        {

        }

        public IGenericRepository<Producto> GetProductoRepository()
        {
                return new Repositories.ProductoRepository();
        }

        public IGenericRepository<Usuario> GetUsuarioRepository()
        {
            return new Repositories.UsuarioRepository();
        }

        public IGenericRepository<ProductoVendido> GetProductoVendidoRepository()
        {
            return new Repositories.ProductoVendidoRepository();
        }

        public IGenericRepository<Venta> GetVentaRepository()
        {
            return new Repositories.VentaRepository();
        }


    }
}
