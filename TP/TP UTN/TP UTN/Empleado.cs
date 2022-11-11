using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class Empleado
    {
        public int empl_codigo { get; set; }
        public string empl_nombre { get; set; }
        public string empl_apellido { get; set; }
        public Empleado empl_supervisor_id { get; set; }

        public Empleado(int empl_codigo, string empl_nombre, string empl_apellido, Empleado empl_supervisor)
        {
            this.empl_codigo = empl_codigo;
            this.empl_nombre = empl_nombre;
            this.empl_apellido = empl_apellido;
            this.empl_supervisor_id = empl_supervisor;
        }   
    }
}
