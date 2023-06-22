namespace Domain
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contrasenia;
        private string mail;

        #region constructores
        public Usuario()
        {
       
            this.nombre = string.Empty;
            this.apellido = string.Empty;  
            this.nombreUsuario = string.Empty;
            this.contrasenia = string.Empty;
            this.mail = string.Empty;
        }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.mail = mail;
        }
        #endregion
    }
}