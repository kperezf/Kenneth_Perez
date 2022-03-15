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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDB _mydb;

        public HomeController(ILogger<HomeController> logger, MyDB mydb)
        {
            _logger = logger;
            _mydb = mydb;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Editarcat()
        {
            return View();
        }

        public IActionResult Crearcateg(Categoria categoria)
        {
            _mydb.Categoria.Add(categoria);
            _mydb.SaveChanges();

            return RedirectToAction("Editarcat");
        }

        public IActionResult Editarprod()
        {
            return View();
        }

        public IActionResult Crearproduct(Producto producto)
        {
            _mydb.Producto.Add(producto);
            _mydb.SaveChanges();

            return RedirectToAction("Editarprod");
        }

        public IActionResult Editarmodu()
        {
            return View();
        }
        
        public IActionResult Crearmodulo(Modulo modulo)
        {
            _mydb.Modulo.Add(modulo);
            _mydb.SaveChanges ();

            return RedirectToAction("Editarmodu");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
  
}
