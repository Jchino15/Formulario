using Microsoft.EntityFrameworkCore;
using PracticaMVC.Models;

namespace PracticaMVC.Models
{
    public class equiposDbContext: DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options)
        { 
        
        }
        public DbSet<marcas> marcas { get; set; }   
        public DbSet<tipo_Equipo> tipo_Equipo { get; set; }
        public DbSet<estados_Equipo>? estados_Equipo { get; set; }
        public DbSet<estados_Reserva>? estados_Reserva { get; set; }
        public DbSet<carreras>? carreras { get; set; }
        public DbSet<facultades>? facultades { get; set; }
        public DbSet<reservas>? reservas { get; set; }
        public DbSet<usuarios>? usuarios { get; set; }
    }
}
