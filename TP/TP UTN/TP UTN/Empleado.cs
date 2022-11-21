using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class Empleado
    {
        public int empl_id { get; set; }
        public string empl_user { get; set; }
        public string empl_nombre { get; set; }
        public string empl_apellido { get; set; }
        public int empl_supervisor_id { get; set; }

        public Empleado(int empl_id, Usuario user, string empl_nombre, string empl_apellido, Empleado supervisor)
        {
            this.empl_id = empl_id;
            this.empl_user = user.usuario_id;
            this.empl_nombre = empl_nombre;
            this.empl_apellido = empl_apellido;
            this.empl_supervisor_id = supervisor.empl_id;
        }   
    }
}
