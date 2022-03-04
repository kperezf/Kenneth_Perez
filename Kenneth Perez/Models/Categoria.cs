using System.ComponentModel.DataAnnotations;

namespace Kenneth_Perez.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage ="Este campo es requerido")]
        public string Nombre { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Descripcion { get; set; }

        public string Fecha { get; set; }
    }
}
