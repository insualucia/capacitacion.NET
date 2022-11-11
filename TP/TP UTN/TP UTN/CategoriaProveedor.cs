using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class CategoriaProveedor
    {
        public int cate_codigo { get; set; }
        public string cate_nombre { get; set; } 

        public CategoriaProveedor(int cate_codigo, string cate_nombre)
        {
            this.cate_codigo = cate_codigo;
            this.cate_nombre = cate_nombre;
        }   
    }
}
