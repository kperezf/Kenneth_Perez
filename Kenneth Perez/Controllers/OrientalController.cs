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
            List<Modulo> modulos = _mydb.Modulo.ToList();
            return View(modulos);
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

        public IActionResult Eliminarcate(int IdCategoria)
        {
            List<Producto> producto = _mydb.Producto.Where(c => c.IdCategoria == IdCategoria).ToList();

            //Elimino todos los productos asociados a la categoria//
            if (producto != null)
                _mydb.RemoveRange(producto);

            //Con el Entity eliminar el valor//
            Categoria categoria = _mydb.Categoria.Where(c => c.IdCategoria == IdCategoria).FirstOrDefault();

              if (categoria != null)
                _mydb.RemoveRange(categoria);

            _mydb.SaveChanges();

            List<Categoria> categorias = _mydb.Categoria.ToList();
            return View("Postgrado");
        }

        public IActionResult Editarmodulo(int IdModulo)
        {
            Modulo modelo = _mydb.Modulo.Where(c => c.IdModulo == IdModulo).FirstOrDefault();
            return View("Editarmodulo", modelo);
        }

        public IActionResult Editarmodulos(Modulo modulo)
        {
            //Recupero el valor actual de la BD//
            Modulo moduloActual = _mydb.Modulo
                .Where(Kenneth_Perez => Kenneth_Perez.IdModulo == modulo.IdModulo).FirstOrDefault();

            //Actualizo el nombre de la Categoria con el nuevo valor//
            moduloActual.Nombre = modulo.Nombre;

            //Persisto los datos en la BD//
            _mydb.SaveChanges();


            List<Modulo> modulos = _mydb.Modulo.ToList();
            return RedirectToAction("Modulo", modulos);
        }

        public IActionResult Eliminarmodulo(int IdModulo)
        {

            //Con el Entity eliminar el valor//
            Modulo modulo = _mydb.Modulo.Where(c => c.IdModulo == IdModulo).FirstOrDefault();

            if (modulo != null)
                _mydb.RemoveRange(modulo);

            _mydb.SaveChanges();

            
            List<Modulo> modulos = _mydb.Modulo.ToList();
            return View("Modulo");
        }

    }
}
