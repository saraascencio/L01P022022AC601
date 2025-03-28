using System.ComponentModel.DataAnnotations;

namespace L01P022022AC601.Models
{
    public class departamentos
    {
        [Key]

        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "El nombre del departamento NO es opcional")]
        public string? departamento { get; set; }
    }
}
