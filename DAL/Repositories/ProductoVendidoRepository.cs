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
    internal class ProductoVendidoRepository : IGenericRepository<ProductoVendido>
    {
        SqlConnection conn = new SqlConnection("Data Source=PCASUS\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True");
        #region Consultas
        string getAllQuerry = @"SELECT Id, Stock, IdProducto, IdVenta
                                FROM     dbo.ProductoVendido";
        #endregion
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductoVendido> GetAll()
        {
            List<ProductoVendido> productosVendidos = new List<ProductoVendido>();
            using (SqlCommand command = new SqlCommand(getAllQuerry, conn))
            {
                conn.Open();
                using (var dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        productosVendidos.Add(new ProductoVendido(int.Parse(dr["Id"].ToString()),int.Parse(dr["Stock"].ToString()), int.Parse(dr["IdProducto"].ToString()), int.Parse(dr["IdProducto"].ToString())));
                    }
                }
                conn.Close();
            }
            return productosVendidos;
        }

        public ProductoVendido GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(ProductoVendido obj)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductoVendido obj)
        {
            throw new NotImplementedException();
        }
    }
}
