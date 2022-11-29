using clase8.Datos;
using clase8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace clase8.Controllers
{
    public class ClienteController : Controller
    {
        ClienteDatos clienteDatos = new ClienteDatos();

        public IActionResult Index()
        {
            var oLista = clienteDatos.Listar();
            return View(oLista);
        }
    }
}



