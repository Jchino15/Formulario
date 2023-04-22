using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class reservas
    {
        [Key]
        [Display(Name = "Reserva ID")]
        public int reserva_id { get; set; }
        [Display(Name = "Equipo ID")]
        public int? equipo_id { get; set; }
        [Display(Name = "Usuario ID")]
        public int? usuario_id { get; set; }
        [Display(Name = "Fecha de salida")]
        public DateTime fecha_salida { get; set; }
        [Display(Name = "Hora de salida")]
        public DateTime hora_salida { get; set; }
        [Display(Name = "Tiempo de reserva")]
        public int? tiempo_reserva { get; set; }
        [Display(Name = "ID de estado de reserva")]
        public int? estado_reserva_id { get; set; }
        [Display(Name = "Fecha de retorno")]
        public DateTime fecha_retorno { get; set; }
        [Display(Name = "Hora de retorno")]
        public DateTime hora_retorno { get; set; }

    }
}
