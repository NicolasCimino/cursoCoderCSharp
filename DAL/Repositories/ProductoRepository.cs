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
    internal class ProductoRepository : IGenericRepository<Producto>
    {
        SqlConnection conn = new SqlConnection("Data Source=PCASUS\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True");
        #region Consultas
        string getAllQuerry = @"SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario
                                FROM     dbo.Producto";
        #endregion
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> GetAll()
        {
            List<Producto> productos = new List<Producto>();
            using (SqlCommand command = new SqlCommand(getAllQuerry, conn))
            {
                conn.Open();
                using (var dr = command.ExecuteReader())
                {
                    while (dr.Read()) 
                    { 
                        productos.Add(new Producto(int.Parse(dr["Id"].ToString()), dr["Descripciones"].ToString(), float.Parse(dr["Costo"].ToString()), float.Parse(dr["PrecioVenta"].ToString()), int.Parse(dr["Stock"].ToString()),int.Parse(dr["IdUsuario"].ToString()))); 
                    }
                }
                conn.Close();
            }
            return productos;
        }

        public Producto GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Producto obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Producto obj)
        {
            throw new NotImplementedException();
        }

   
    }
}
