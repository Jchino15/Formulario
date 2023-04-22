using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class carreras
    {
        [Key]
        [Display(Name = "ID")]
        public int carrera_id { get; set; }
        [Display(Name = "Nombre de carrera")]
        public string? nombre_carrera { get; set; }
        [Display(Name = "ID de facultad")]
        public int facultad_id { get; set; }
    }
}
