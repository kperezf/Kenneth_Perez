using Kenneth_Perez.Data;
using Kenneth_Perez.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Kenneth_Perez.Controllers
{
    public class OrientalController : Controller
    {   
        //Para poder utilizar las funciones de otros controladores realizamos lo siguiente
        private readonly MyDB _mydb;

        public OrientalController(MyDB mydb)
        {
            _mydb = mydb;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Postgrado()
        {
            List<Categoria> categoria = _mydb.Categoria.ToList();            
            return View(categoria);
        }

        public IActionResult Productos()
        {
            List<Producto> producto = _mydb.Producto.ToList();
            return View(producto);
        }

        public IActionResult Modulo()
        {
            List<Modulo> modulo = _mydb.Modulo.ToList();
            return View(modulo);
        }

    }
}
