using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022022AC601.Models
{
    public class alumnos
    {
        [Key]

        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "El código de alumno NO es opcional")]
        public string? codigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre de alumno NO es opcional")]
        public string? nombre { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Los apellidos del alumno NO son opcionales")]
        public string? apellidos { get; set; }

        [Display(Name = "DUI")]
        public int? dui { get; set; }

        [Display(Name = "Estado")]
        public int? estado { get; set; }
    }
}
