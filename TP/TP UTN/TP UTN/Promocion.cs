using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class Promocion
    {
        public int prom_codigo { get; set; }
        public int prom_descuento { get; set; }
        public DateTime prom_fecha_inicio { get; set; }
        public DateTime prom_fecha_fin { get; set; }

        public Promocion(int prom_codigo, int prom_descuento, DateTime prom_fecha_inicio, DateTime prom_fecha_fin)
        {
            this.prom_codigo = prom_codigo;
            this.prom_descuento = prom_descuento;
            this.prom_fecha_inicio = prom_fecha_inicio;
            this.prom_fecha_fin = prom_fecha_fin;
        }   
    }
}
