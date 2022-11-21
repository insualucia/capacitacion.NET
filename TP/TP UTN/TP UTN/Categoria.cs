using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class Categoria
    {
        public int cate_id { get; set; }
        public string cate_nombre { get; set; } 

        public Categoria(int cate_id, string cate_nombre)
        {
            this.cate_id = cate_id;
            this.cate_nombre = cate_nombre;
        }   
    }
}
