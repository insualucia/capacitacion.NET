using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class PromocionProducto
    {
        public int pp_codigo { get; set; }
        public Producto prod_codigo { get; set; }
        public Promocion prom_codigo { get; set; }

        public PromocionProducto(int pp_codigo, Producto prod_codigo, Promocion prom_codigo)
        {
            this.pp_codigo = pp_codigo;
            this.prod_codigo = prod_codigo;
            this.prom_codigo = prom_codigo;
        } 
    }
}
