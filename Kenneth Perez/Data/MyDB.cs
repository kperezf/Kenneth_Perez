using Kenneth_Perez.Models;
using Microsoft.EntityFrameworkCore;

namespace Kenneth_Perez.Data
{
    public class MyDB : DbContext
    {
        public MyDB(DbContextOptions<MyDB> options) : base(options)
        {

        }

        //Una propiedad por cada tabla
        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Producto> Producto { get; set; }

        public DbSet<Modulo> Modulo { get; set; }
    }
}
