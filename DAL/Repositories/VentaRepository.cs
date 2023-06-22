using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    internal class VentaRepository : IGenericRepository<Venta>
    {
        SqlConnection conn = new SqlConnection("Data Source=PCASUS\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True");
        #region Consultas
        string getAllQuerry = @"SELECT Id, Comentarios, IdUsuario
                                FROM     dbo.Venta";
        #endregion
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Venta> GetAll()
        {
            List<Venta> ventas = new List<Venta>();
            using (SqlCommand command = new SqlCommand(getAllQuerry, conn))
            {
                conn.Open();
                using (var dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ventas.Add(new Venta(int.Parse(dr["Id"].ToString()), dr["Comentarios"].ToString(), int.Parse(dr["IdUsuario"].ToString())));
                    }
                }
                conn.Close();
            }
            return ventas;
        }

        public Venta GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Venta obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Venta obj)
        {
            throw new NotImplementedException();
        }
    }
}
