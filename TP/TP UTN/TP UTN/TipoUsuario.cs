using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class TipoUsuario
    {
        public char tipo_id { get; set; }
        public string tipo_descripcion { get; set; } 

        public TipoUsuario(int tipo_id, string tipo_descripcion)
        {
            this.tipo_id = tipo_id;
            this.tipo_descripcion = tipo_descripcion;
        }   
    }
}
