using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class Promocion
    {
        public int prom_id { get; set; }
        public string prom_nombre { get; set; }   
        public decimal prom_descuento { get; set; }
        public string? prom_imagen { get; set; }
        public string? prom_descripcion { get; set; }

        public Promocion(int prom_id, string prom_nombre, decimal prom_descuento, string? prom_imagen, string? prom_descripcion)
        {
            this.prom_id = prom_id;
            this.prom_nombre = prom_nombre;
            this.prom_descuento = prom_descuento;
            this.prom_imagen = prom_imagen;
            this.prom_descripcion = prom_descripcion;
            
        }   
    }
}
