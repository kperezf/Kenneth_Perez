using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kenneth_Perez.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public int IdCategoria { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Nombre { get; set; }

        [Range(0, 999.99)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Precio { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Descripcion { get; set; }

        public string Fecha { get; set; }

        //Crear la relaciòn entre las tablas
        [ForeignKey ("IdCategoria")]
        public Categoria Categoria { get; set; }
    }
}
