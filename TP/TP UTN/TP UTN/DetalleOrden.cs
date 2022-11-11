using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    internal class DetalleOrden
    {
        public int deta_codigo { get; set; }
        public int deta_cantidad { get; set; }
        public decimal deta_importe { get; set; }
        public decimal deta_precio_unitario { get; set; }
        public PromocionProducto pp_codigo { get; set; }
        public OrdenCompra orde_codigo { get; set; }

        public DetalleOrden(int deta_codigo, int deta_cantidad, decimal deta_importe, decimal deta_precio_unitario, PromocionProducto pp_codigo, OrdenCompra orde_codigo)
        {
            this.deta_codigo = deta_codigo;
            this.deta_cantidad = deta_cantidad;
            this.deta_importe = deta_importe;
            this.deta_precio_unitario = deta_precio_unitario;
            this.pp_codigo = pp_codigo;
            this.orde_codigo = orde_codigo;
        } 



    }
}
