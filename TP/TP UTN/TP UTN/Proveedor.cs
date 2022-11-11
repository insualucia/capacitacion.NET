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



    }
}
