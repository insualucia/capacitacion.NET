

namespace Ejercicio
{
    public class Auto
    {
        //Atributos
        private string color;
        private string marca;
        private string modelo;
        private string patente;
        private int cantidadDePuertas;
        private DateTime fechaDeCreacion;

        //Constructores
        public Auto(string colorParametro, string marcaParametro, string modeloParametro, string patenteParametro, int cantidadDePuertasParametro)
        {
            this.color = colorParametro;
            this.marca = marcaParametro;
            this.modelo = modeloParametro;
            this.patente = patenteParametro;
            this.cantidadDePuertas = cantidadDePuertasParametro;
            this.fechaDeCreacion = DateTime.Now;
        }

        public Auto() { }

        //Getters
        public string GetMarca()
        {
            return this.marca;
        }
        public string GetModelo()
        {
            return this.modelo;
        }
        public string GetPatente()
        {
            return this.patente;
        }

        public string ConcatenarMarcaModelo()
        {
            string concatenacion = $"Modelo: {this.modelo} Marca: {this.marca}";
            return concatenacion;
        }
        public DateTime GetFechaDeCreacion()
        {

            return this.fechaDeCreacion;
        }

    }
    public class Moto
    {

    }
}
