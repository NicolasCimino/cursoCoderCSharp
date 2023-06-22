using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Producto
    {
        private int id;
        private string descripcion;
        private float costo;
        private float precioVenta;
        private int stock;
        private int idProducto;

        #region constructores
        public Producto()
        {

            this.descripcion = string.Empty;
            this.costo = 0;
            this.precioVenta = 0;
            this.stock = 0;

        }

        public Producto(int id, string descripcion, float costo, float precioVenta, int stock, int idProducto)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idProducto = idProducto;
        }
        #endregion
    }
}
