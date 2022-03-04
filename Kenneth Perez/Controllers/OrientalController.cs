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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Postgrado()
        {
            //Simular los datos como si tenemos la BD
            List<Categoria> categorias = new List<Categoria>();

            categorias.Add (new Categoria()
            {
                IdCategoria = "01",
                Nombre = "Kenneth Perez",
                Descripcion = "Cualquiera",
                Fecha = "10/02/2022"
            });

            categorias.Add(new Categoria()
            {
                IdCategoria = "03",
                Nombre = "Francela Sevilla",
                Descripcion = "Cualquiera",
                Fecha = "12/02/2022"
            });

            categorias.Add(new Categoria()
            {
                IdCategoria = "04",
                Nombre = "Cristobal Cruz",
                Descripcion = "Cualquiera",
                Fecha = "22/02/2022"
            });


            return View(categorias);
        }

        public IActionResult Productos()
        {
            //Simular los datos como si tenemos la BD
            List<Producto> productos = new List<Producto>();

            productos.Add(new Producto()
            {
                IdProducto = "10",
                IdCategoria = "04",
                Nombre = "Kenneth Perez",
                Precio = 100,
                Descripcion = "Cualquiera",
                Fecha = "15/02/2022"
            });

            productos.Add(new Producto()
            {
                IdProducto = "11",
                IdCategoria = "05",
                Nombre = "Fracela Sevilla",
                Precio = 150,
                Descripcion = "Cualquiera",
                Fecha = "25/02/2022"
            });

            productos.Add(new Producto()
            {
                IdProducto = "09",
                IdCategoria = "07",
                Nombre = "Cristobal Cruz",
                Precio = 300,
                Descripcion = "Cualquiera",
                Fecha = "25/03/2022"
            });


            return View(productos);
        }
    }
}
