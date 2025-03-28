using System.ComponentModel.DataAnnotations;

namespace L01P022022AC601.Models
{
    public class facultades
    {
        [Key]

        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Facultad")]
        [Required(ErrorMessage = "El nombre de la facultad NO es opcional")]
        public string? facultad { get; set; }


    }
}
