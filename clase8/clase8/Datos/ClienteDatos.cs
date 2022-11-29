using clase8.Models;
using clase8.Datos;
using System.Data.SqlClient;
using System.Data;


namespace clase8.Datos
{
    public class ClienteDatos
    {
        //Acá se definen los métodos CRUD (ABML)
        public List<Cliente> Listar()
        {

            /*
             Rl paso a paso es:
            BBDD >> Conexion >> Modelos >> Controladores >> Vistas
             */

            //Recibir informacion
            var oLista = new List<Cliente>();

            //Instancia de la conexión
            var conexion = new Conexion();

            //usando using, defiimos el tiempo de vida de la conexion
            using( var conexionTemp = new SqlConnection(conexion.getCadenaSQL()))
            {
                conexionTemp.Open();
                SqlCommand cmd = new SqlCommand("Listar", conexionTemp);
                cmd.CommandType = CommandType.StoredProcedure;
                // comienza la lectura de datos
                using(var lector = cmd.ExecuteReader())
                {
                    //mientras hayan registros
                    while (lector.Read())
                    {
                        oLista.Add(new Cliente()
                        {
                            id = Convert.ToInt32(lector["id"]),
                            nombre = Convert.ToString(lector["nombre"]),
                            telefono = Convert.ToString(lector["telefono"]),
                            email = Convert.ToString(lector["email"])
                        });
                    }
                }
                return oLista;
            }
        }
    }
}



