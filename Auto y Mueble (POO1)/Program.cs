
namespace Ejercicio
{
    public class Program
    {
        static void Main(string[] args)
        {
            //objetos
            Auto fordFiesta = new Auto("Plateado", "Ford", "Fiesta", "ABC3857", 5);
            Auto fiatBrava = new Auto("Gris", "Fiat", "Fiesta", "KKET0685", 5);
            Auto chevroletOnyx = new Auto("Negro", "Chevrolet", "Onyx", "TYRR3845", 5);
            Auto mcQueen = new Auto();

            Console.WriteLine(fordFiesta.GetPatente() + " " 
                + fordFiesta.GetModelo() + " " 
                + fordFiesta.GetMarca()+ " "
                + fordFiesta.GetFechaDeCreacion());

            Console.WriteLine($"{fordFiesta.GetModelo()} {fordFiesta.GetMarca()} {fordFiesta.GetFechaDeCreacion()}");

            Console.WriteLine(fiatBrava.ConcatenarMarcaModelo());

            Mueble silla = new Mueble("Silla", 100, 70, "Metal", 10);
            Mueble mesa = new Mueble("Mesa", 120, 150, "Plastico", 15);
            Mueble escritorio = new Mueble("Escritorio", 130, 90, "Vidrio", 11);

            Console.WriteLine(silla.GetNombre() + " \n" +silla.GetMaterial());
            silla.SetMaterial("Madera");
            Console.WriteLine(silla.GetMaterial());

        }
    }
    //public class Auto
    //{
    //    ////Atributos
    //    //private string color;
    //    //private string marca;
    //    //private string modelo;
    //    //private string patente;
    //    //private int cantidadDePuertas;

    //    ////Constructores
    //    //public Auto(string color, string marca, string modelo, string patente, int cantidadDePuertas)
    //    //{
    //    //    this.color = color;
    //    //    this.marca = marca;
    //    //    this.modelo = modelo;
    //    //    this.patente = patente;
    //    //    this.cantidadDePuertas = cantidadDePuertas;
    //    //}

    //    //public Auto() { }

    //    ////Getters
    //    //public string GetMarca()
    //    //{
    //    //    return this.marca;
    //    //}
    //    //public string GetModelo()
    //    //{
    //    //    return this.modelo;
    //    //}
    //    //public string GetPatente()
    //    //{
    //    //    return this.patente;
    //    //}
    //}

    //public class Mueble
    //{
    //    private string nombre;
    //    private int alto;
    //    private int ancho;
    //    private string material;
    //    private int cantidad;


    //    public Mueble(string nombre, int alto, int ancho, string material, int cantidad)
    //    {
    //        this.nombre = nombre;
    //        this.alto = alto;
    //        this.ancho = ancho;
    //        this.material = material;
    //        this.cantidad = cantidad;
    //    }

    //    public string GetNombre()
    //    {
    //        return this.nombre;
    //    }

    //    public string GetMaterial()
    //    {
    //        return this.material;
    //    }
        
    //    public void SetMaterial(string material)
    //    {
    //        this.material = material;
    //    }
    //}
}



