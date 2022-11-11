using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class Proveedor
    {
        public int prov_codigo { get; set; }
        public string prov_nombre { get; set; }
        public string prov_direccion { get; set; }
        public int prov_cuit { get; set; }
        public CategoriaProveedor cate_codigo { get; set; }

        public Proveedor(int prov_codigo, string prov_nombre, string prov_direccion, int prov_cuit, CategoriaProveedor cate_codigo)
        {
            this.prov_codigo = prov_codigo;
            this.prov_nombre = prov_nombre;
            this.prov_direccion = prov_direccion;
            this.prov_cuit = prov_cuit;
            this.cate_codigo = cate_codigo;
        }   


    }
}
