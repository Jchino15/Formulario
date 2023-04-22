using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class estados_Reserva
    {
        [Key]
        [Display(Name = "ID")]
        public int estado_res_id { get; set; }
        [Display(Name = "Estado")]
        public string? estado { get; set; }

    }
}
