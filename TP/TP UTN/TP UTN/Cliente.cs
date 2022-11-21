using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UTN
{
    public class Cliente
    {
        public int clie_id { get; set; }
        public string clie_user { get; set; }
        public string clie_nombre { get; set; } 
        public string clie_apellido { get; set; }   
        public string clie_razon_social { get; set; }   
        public int? clie_cuil { get; set; }
        public int? clie_dni { get; set; }
        public string clie_tipo { get; set; }


        public Cliente(int clie_id, Usuario user, string clie_nombre, string clie_apellido, string clie_razon_social, int? clie_cuil, int? clie_dni, string clie_tipo)
        {
            this.clie_id = clie_id;
            this.clie_user = user.usuario_id;
            this.clie_nombre = clie_nombre;
            this.clie_apellido = clie_apellido;
            this.clie_razon_social = clie_razon_social;
            this.clie_cuil = clie_cuil;
            this.clie_dni = clie_dni;
            this.clie_tipo = clie_tipo;
        }   

    }
}
