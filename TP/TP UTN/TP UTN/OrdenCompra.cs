using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class OrdenCompra
    {
        public int orde_codigo { get; set; }
        public DateTime orde_fecha_compra { get; set; }
        public Cliente clie_codigo { get; set; }
        public Empleado empl_codigo { get; set; }

        public OrdenCompra(int orde_codigo, Cliente clie_codigo, Empleado empl_codigo)
        {
            this.orde_codigo = orde_codigo;
            this.orde_fecha_compra = DateTime.Now;
            this.clie_codigo = clie_codigo;
            this.empl_codigo = empl_codigo;
        }   
    }
}
