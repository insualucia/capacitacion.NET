
namespace Ejercicios
{
    public class Program
    {
        static void Main(string[] args)
            {
            ListasYVectores ejercicio = new ListasYVectores();
            Console.WriteLine("Ingrese qué ejercicio desea compilar.");
            int numeroDeEjercicio = int.Parse(Console.ReadLine());
            ejercicio.inicio(numeroDeEjercicio);
            }

    }
}