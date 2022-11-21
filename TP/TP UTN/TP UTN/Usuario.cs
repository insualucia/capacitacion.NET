using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class Usuario
    {
        public string usuario_id { get; set; }
        public string user_nombre { get; set; }
        public string user_contrasena { get; set; }
        public char user_tipo { get; set; }

        public Usuario(string usuario_id, string user_nombre, string user_contrasena, TipoUsuario tipoUsuario)
        {
            this.usuario_id = usuario_id;
            this.user_nombre = user_nombre; 
            this.user_contrasena = user_contrasena;
            this.user_tipo = tipoUsuario.tipo_id;
        }
    }
}
