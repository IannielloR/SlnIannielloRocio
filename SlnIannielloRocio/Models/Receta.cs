using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using SlnIannielloRocio.Validations;

namespace SlnIannielloRocio.Models
{
    public class Receta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(2000)")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(2000)")]
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(2000)")]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        public string AutorNombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        public string AutorApellido { get; set;}

        public int Edad { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [RegularExpression("^[^@]+@[^@]+\\.[a-zA-Z]{2,}$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [ValidCategory]
        public string Categoria { get; set; }

    }
}
