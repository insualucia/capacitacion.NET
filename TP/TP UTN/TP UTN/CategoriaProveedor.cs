using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class CategoriaProveedor
    {
        public int cp_id { get; set; }
        public int cp_categoria { get; set; }
        public int cp_proveedor { get; set; }

public CategoriaProveedor(int cp_id, Categoria categoria, Proveedor proveedor)
        {
            this.cp_id = cp_id;
            this.cp_categoria = categoria.cate_id;
            this.cp_proveedor = proveedor.prov_id;
        }   
    }
}
