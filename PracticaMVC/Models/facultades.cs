using System.ComponentModel.DataAnnotations;


namespace PracticaMVC.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int facultad_id { get; set; }
        [Display(Name = "Nombre de facultad")]
        public string? nombre_facultad { get; set; }

    }
}
