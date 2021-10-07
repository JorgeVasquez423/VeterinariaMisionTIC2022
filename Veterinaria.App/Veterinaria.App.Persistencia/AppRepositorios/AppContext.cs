using System;
using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; } /* personas es una tabla */

        public DbSet<Veterinario> Veterinarios { get; set; }

        public DbSet<Administrador> Administradores { get; set; }

        public DbSet<Cuidador> Cuidadores { get; set; }

        public DbSet<Mascota> Mascotas { get; set;}

        public DbSet<Agenda> Agendas { get; set;}

        public DbSet<Cita> Citas { get; set;}

        public DbSet<HistoriaClinica> HistoriaClinicas { get; set;}

        public DbSet<Vacuna> Vacunas { get; set;}



        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder
        )
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = VeterinariaEquipo1");
            }
        }
    }
}
