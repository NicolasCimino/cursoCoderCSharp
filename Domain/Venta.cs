using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Venta
    {
        private int id;
        private string comentarios;
        private int idUsuario;

        #region constructores
        public Venta()
        {
       
            this.comentarios = string.Empty;

        }

        public Venta(int id, string comentarios, int idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
        }
        #endregion
    }
}
