using Kenneth_Perez.Data;
using Kenneth_Perez.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kenneth_Perez.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly MyDB _mydb;

        public ValuesController(MyDB mydb)
        {
            _mydb = mydb;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Categoria> Get()
        {
            IEnumerable<Categoria> categorias = _mydb.Categoria.ToList();
            return categorias;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Categoria Get(int IdCategoria)
        {
            Categoria categoria = _mydb.Categoria.Where(c => c.IdCategoria == IdCategoria).FirstOrDefault();

            if (categoria == null)
                return new Categoria();
            return categoria;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
