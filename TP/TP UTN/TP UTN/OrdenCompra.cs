using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class OrdenCompra
    {
        public int orde_id { get; set; }
        public DateTime orde_fecha_compra { get; set; }
        public int orde_empleado { get; set; }
        public int orde_cliente { get; set; }

        public OrdenCompra(int orde_id, Cliente cliente, Empleado empleado)
        {
            this.orde_id = orde_id;
            this.orde_fecha_compra = DateTime.Now;
            this.orde_cliente = cliente.clie_id;
            this.orde_empleado = empleado.empl_id;
        }   
    }
}
