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
            List<Categoria> categorias = _mydb.Categoria.ToList();            
            return View(categorias);
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

        public IActionResult Editarcate(int IdCategoria)
        {
            Categoria modelo = _mydb.Categoria.Where(c => c.IdCategoria == IdCategoria).FirstOrDefault();
            return View("Editarcate", modelo);
        }

        public IActionResult Editarcategoria(Categoria categoria)
        {
            //Recupero el valor actual de la BD//
            Categoria categoriasActual = _mydb.Categoria
                .Where(Kenneth_Perez => Kenneth_Perez.IdCategoria == categoria.IdCategoria).FirstOrDefault();

            //Actualizo el nombre de la Categoria con el nuevo valor//
            categoriasActual.Nombre = categoria.Nombre;

            //Persisto los datos en la BD//
            _mydb.SaveChanges();

            List<Categoria> categorias = _mydb.Categoria.ToList();
            return RedirectToAction("Postgrado", categorias);
        }

    }
}
