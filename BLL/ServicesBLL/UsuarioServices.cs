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
    public sealed class UsuarioServices : IGenericRepositoryBLL<Usuario>
    {

        private readonly static UsuarioServices _instance = new UsuarioServices();

        public static UsuarioServices Current
        {
            get
            {
                return _instance;
            }
        }

        IGenericRepository<Usuario> usuarioRepository = Factory.Current.GetUsuarioRepository();
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetOne(int id)
        {
            return usuarioRepository.GetOne(id);
        }

        public void Insert(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
