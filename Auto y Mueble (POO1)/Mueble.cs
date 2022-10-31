using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Mueble
    {
        private string nombre;
        private int alto;
        private int ancho;
        private string material;
        private int cantidad;


        public Mueble(string nombre, int alto, int ancho, string material, int cantidad)
        {
            this.nombre = nombre;
            this.alto = alto;
            this.ancho = ancho;
            this.material = material;
            this.cantidad = cantidad;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetMaterial()
        {
            return this.material;
        }

        public void SetMaterial(string material)
        {
            this.material = material;
        }
    }
}
