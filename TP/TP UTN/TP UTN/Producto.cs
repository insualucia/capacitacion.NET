using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class Producto
    {
        public int prod_codigo { get; set; }
        public int prod_stock { get; set; }
        public string prod_nombre { get; set; }
        public decimal prod_precio { get; set; }
        public Proveedor prov_codigo { get; set; }

        public Producto(int prod_codigo, int prod_stock, string prod_nombre, decimal prod_precio, Proveedor prov_codigo)
        {
            this.prod_codigo = prod_codigo;
            this.prod_stock = prod_stock;
            this.prod_nombre = prod_nombre;
            this.prod_precio = prod_precio;
            this.prov_codigo = prov_codigo;
        }   
    }
}
