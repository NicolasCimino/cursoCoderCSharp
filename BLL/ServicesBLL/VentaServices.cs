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
    public sealed class VentaServices :IGenericRepositoryBLL<Venta>
    {
        private readonly static VentaServices _instance = new VentaServices();

        public static VentaServices Current
        {
            get
            {
                return _instance;
            }
        }

        private VentaServices()
        {

        }

        IGenericRepository<Venta> ventaRepository = Factory.Current.GetVentaRepository();
        public void Insert(Venta obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Venta obj)
        {
            throw new NotImplementedException();
        }

        public Venta GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Venta> GetAll()
        {
            return ventaRepository.GetAll();
        }
    }
}
