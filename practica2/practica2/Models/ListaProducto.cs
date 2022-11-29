namespace practica2.Models
{
    public class ListaProducto
    {
        public List<Producto> listaProducto = new List<Producto>()
            {
                new Producto(010, "Labial MAC", 1200.99m, "MAC", 25),
                new Producto(020, "Base NATURA", 1000.99m, "NATURA", 15),
                new Producto(030, "Mascara de pestañas RIMMEL", 1500.99m, "RIMMEL", 19),
                new Producto(040, "Sombra MAC", 1500.69m, "MAC", 13)
            };
        public void Agregar(Producto producto)
        {
            listaProducto.Add(producto);
        }
    }
}
