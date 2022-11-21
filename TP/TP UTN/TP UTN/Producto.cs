using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class Producto
    {
        public int prod_id { get; set; }
        public int prod_stock { get; set; }
        public string prod_nombre { get; set; }
        public decimal prod_precio { get; set; }
        public int prod_proveedor { get; set; }
        public string? prod_imagen { get; set; }
        public string? prod_descripcion { get; set; }   

        public Producto(int prod_codigo, int prod_stock, string prod_nombre, decimal prod_precio, Proveedor proveedor, string? prod_imagen, string? prod_descripcion)
        {
            this.prod_id = prod_codigo;
            this.prod_stock = prod_stock;
            this.prod_nombre = prod_nombre;
            this.prod_precio = prod_precio;
            this.prod_proveedor = proveedor.prov_id;
            this.prod_imagen = prod_imagen;
            this.prod_descripcion = prod_descripcion;
        }   
    }
}
