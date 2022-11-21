using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class PromocionProducto
    {
        public int pp_id { get; set; }
        public int pp_producto { get; set; }
        public int pp_promocion { get; set; }
        public DateTime pp_fecha_inicio { get; set; }
        public DateTime pp_fecha_fin { get; set; }


        public PromocionProducto(int pp_id, Producto producto, Promocion promocion, DateTime pp_fecha_inicio, DateTime pp_fecha_fin)
        {
            this.pp_id = pp_id;
            this.pp_producto = producto.prod_id;
            this.pp_promocion = promocion.prom_id;
            this.pp_fecha_inicio = pp_fecha_inicio;
            this.pp_fecha_fin = pp_fecha_fin;
        } 
    }
}
