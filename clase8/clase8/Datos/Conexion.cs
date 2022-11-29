using System.Data.SqlClient;

namespace clase8.Datos
{
    public class Conexion
    {
        private string cadenaSQL = string.Empty;

        //Constructor
        public Conexion ()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").Build();
            
            cadenaSQL = builder.GetSection("ConnectionStrings:CadenaSQL").Value;
        }

        //Getter de la cadena de SQL
        public string getCadenaSQL()
        { return cadenaSQL; }
    }
}
