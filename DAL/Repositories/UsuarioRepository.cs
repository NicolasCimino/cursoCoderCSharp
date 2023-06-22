using System;
using DAL.Contracts;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    internal class UsuarioRepository : IGenericRepository<Usuario>
    {
        SqlConnection conn = new SqlConnection("Data Source=PCASUS\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True");
        #region Consultas
        string getAllQuerry = @"SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail
                                FROM     dbo.Usuario
                                WHERE Id = @Id";
        #endregion
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
            Usuario usuario = new Usuario();
            using (SqlCommand command = new SqlCommand(getAllQuerry, conn))
            {
                command.Parameters.Add(new SqlParameter("@Id", id.ToString()));
                conn.Open();
                using (var dr = command.ExecuteReader())
                {
                    dr.Read();
                    usuario = new Usuario(int.Parse(dr["Id"].ToString()), dr["Nombre"].ToString(), dr["Apellido"].ToString(), dr["NombreUsuario"].ToString(), dr["Contraseña"].ToString(), dr["Mail"].ToString());

                }
                conn.Close();
            }
            return usuario;
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
