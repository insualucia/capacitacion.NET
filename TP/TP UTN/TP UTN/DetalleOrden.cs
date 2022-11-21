using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    internal class DetalleOrden
    {
        public int deta_id { get; set; }
        public int deta_orden { get; set; }
        public int deta_producto { get; set; }
        public int deta_cantidad { get; set; }
        public decimal deta_precio_unitario { get; set; }
        public decimal? deta_descuento { get; set; }

        public DetalleOrden(int deta_id, OrdenCompra ordenCompra, Producto producto, int deta_cantidad, decimal deta_precio_unitario, decimal? deta_descuento)
        {
            this.deta_id = deta_id;
            this.deta_orden = ordenCompra.orde_id;
            this.deta_producto = producto.prod_id;
            this.deta_cantidad = deta_cantidad;
            this.deta_descuento = deta_descuento;
            this.deta_precio_unitario = deta_precio_unitario;
        } 



    }
}
